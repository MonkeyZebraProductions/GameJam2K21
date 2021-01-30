using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOpener : MonoBehaviour
{
    
    public bool opened = false;
    public float portalTime;

    public GameObject portalCentre;

    public void Open()
    {
        Debug.Log("Hello from portal script!");
    }

    public void StartOpen()
    {
        StartCoroutine("OpenPortal");
    }

    IEnumerator OpenPortal()
    {
        //Play portal opening animation.
        //for loop Size of portal background.
        //activate collider object that'll count/ yeet the object.
        portalCentre.SetActive(true);
        yield return new WaitForSeconds(portalTime);
        //Play portal closing animation.
        //for loop size of portal background back down.
        //turn off collider object that'll count/yeet the object.
        portalCentre.SetActive(false);
    }
}
