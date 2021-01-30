using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProcessItem : MonoBehaviour
{
    public GameManager manager;
    public enum destinations {Dog,Child,Man,Old,Homework,Miner,Squirrel,Buisness};
    public destinations destinationChoice;

    private ItemDesignation itemHit;

    void OnTriggerEnter2D(Collider2D other)
    {
        if(other.gameObject.CompareTag("Item"))
        {
            itemHit = other.gameObject.GetComponent<ItemDesignation>();
            switch (destinationChoice)
            {
                case destinations.Dog:
                {
                    if(itemHit.destination == "Dog")
                    {
                        manager.dogPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Child:
                {
                    if(itemHit.destination == "Child")
                    {
                        manager.childPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Man:
                {
                    if(itemHit.destination == "Man")
                    {
                        manager.manPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Old:
                {
                    if(itemHit.destination == "Old")
                    {
                        manager.oldPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Homework:
                {
                    if(itemHit.destination == "Homework")
                    {
                        manager.homeworkPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Miner:
                {
                    if(itemHit.destination == "Miner")
                    {
                        manager.minerPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Squirrel:
                {
                    if(itemHit.destination == "Squirrel")
                    {
                        manager.squirrelPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                case destinations.Buisness:
                {
                    if(itemHit.destination == "Buisness")
                    {
                        manager.buisnessPortal = true;
                    }
                    else
                    {
                        other.gameObject.GetComponent<Rigidbody2D>().velocity = Vector2.Lerp(new Vector2(-3,-3), new Vector2(3,3), Random.value);
                    }
                    break;
                }
                default:
                {
                    Debug.Log("If this ever shows up something has gone SERIOUSLY wrong xD");
                    break;
                }
            }
        }
    }
}
