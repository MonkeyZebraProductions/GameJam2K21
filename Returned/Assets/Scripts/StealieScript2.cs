using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealieScript2 : MonoBehaviour
{
    public Transform Player, holdSpot;
    public float Speed,WaitTime;
    private Transform[] movePoints;

    private bool _isFollow,_isPlayerHolding,_isStealieHolding, _isStunned;
    private PlayerMovement playerMovement;
    private StealieManager stealieManager;
    private float _randomMoveSpotPicker;
    private Collider2D collider2D;
   
    // Start is called before the first frame update
    void Start()
    {
        _isFollow = true;
        Player= GameObject.FindGameObjectWithTag("Player").transform;
        playerMovement = FindObjectOfType<PlayerMovement>();
        stealieManager = FindObjectOfType<StealieManager>();
        collider2D = GetComponent<Collider2D>();
        int i = 0;
        foreach(Transform element in stealieManager.MovePositions)
        {
            movePoints[i] = stealieManager.MovePositions[i];
            i++;
        }
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        _isPlayerHolding = playerMovement.holdingSomething;

        //Checks whether or nor to follow the player
        if(_isPlayerHolding && !_isStunned || stealieManager._previousItems<=4 && !_isStunned)
        {
            _isFollow = true;
        }
        else
        {
            _isFollow = false;
        }

        //Goes to position if holding items
        if (_isStealieHolding)
        {
            _isFollow = false;
            transform.position = Vector3.MoveTowards(transform.position, movePoints[(int)_randomMoveSpotPicker].position, Speed * Time.deltaTime);

            //drops item when reached position
            if(transform.position== movePoints[(int)_randomMoveSpotPicker].position)
            {
                playerMovement.heldObject.transform.SetParent(null);
                Rigidbody2D objRb = playerMovement.heldObject.GetComponent<Rigidbody2D>();
                objRb.simulated = true;
                playerMovement.heldObject.GetComponent<BoxCollider2D>().enabled = true;
                playerMovement.holdingSomething = false;
                _isStealieHolding = false;
            }
        }


        //checks if Stealie can follow player
        if(_isFollow)
        {
            transform.position = Vector3.MoveTowards(transform.position, Player.position, Speed * Time.deltaTime);
        }
        
    }
    
    
    //checks if collides with item and player
    private void OnCollisionEnter2D(Collision2D collision)
    {
        if(collision.gameObject.layer==8)
        {
            Physics2D.IgnoreCollision(collision.collider, collider2D);
        }
        if (collision.gameObject.tag == "Player")
        {
            playerMovement.heldObject.transform.SetParent(holdSpot);
            playerMovement.holdingSomething = false;
            _isStealieHolding = true;
            
            _randomMoveSpotPicker = Random.Range(0f, movePoints.Length);
        }

        if (collision.gameObject.tag=="Item")
        {
            StartCoroutine(Stunned());
        }
    }

    //Stops following player
    IEnumerator Stunned()
    {
        _isStunned = true;
        yield return new WaitForSeconds(WaitTime);
        _isStunned = false;

    }
}
