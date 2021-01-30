using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StealieManager : MonoBehaviour
{
    private GameObject[] _items;
    public Transform[] MovePositions;
    public GameObject Stealie;

    public int _previousItems;
    private float _randomMoveSpotPicker;
    // Start is called before the first frame update
    void Start()
    {
        _items = GameObject.FindGameObjectsWithTag("Item");
        _previousItems = _items.Length;
    }

    // Update is called once per frame
    void Update()
    {
        _items = GameObject.FindGameObjectsWithTag("Item");
        if (_items.Length<_previousItems)
        {
            _randomMoveSpotPicker = Random.Range(0f, MovePositions.Length);
            Instantiate(Stealie, MovePositions[(int) _randomMoveSpotPicker].position, Quaternion.identity);
            _previousItems = _items.Length;
        }
    }
}
