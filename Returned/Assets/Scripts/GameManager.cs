using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameManager : MonoBehaviour
{
    public bool dogPortal = false;
    public bool childPortal = false;
    public bool manPortal = false;
    public bool oldPortal = false;
    public bool homeworkPortal = false;
    public bool minerPortal = false;
    public bool squirrelPortal = false;
    public bool buisnessPortal = false;


    public GameObject endScene;

    void Update()
    {
        if(dogPortal && childPortal && manPortal && oldPortal && homeworkPortal && minerPortal && squirrelPortal && buisnessPortal)
        {
            endScene.SetActive(true);
        }
    }
}
