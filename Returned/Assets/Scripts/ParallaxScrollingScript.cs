using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ParallaxScrollingScript : MonoBehaviour
{
    public GameObject player;
    float playerXPos;
    public float scrollMultiplier;
    Material bgMat;

    // Start is called before the first frame update
    void Start()
    {
        bgMat = gameObject.GetComponent<Renderer>().material; //gets the material assigned to this gameobject
    }

    // Update is called once per frame
    void Update()
    {
        playerXPos = player.transform.position.x; //gets the player's current Xposition
        bgMat.mainTextureOffset = new Vector2 (playerXPos * scrollMultiplier, bgMat.mainTextureOffset.y); //since texture offset uses x and y values, it is a Vector 2. You can assign it a new X value that updates every frame, and keep the y value the same by referencing itself
    }
}
