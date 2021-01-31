using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PortalOpener : MonoBehaviour
{
    
    public bool opened = false;
    public float portalTime;

    public GameObject portalCentre,PortalInnard;

    public AudioSource PortalOpen, PortalClose;
    public Animator PortalAnim,InnardAnim;

   
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
        PortalInnard.SetActive(true);
        //PortalAnim.SetBool("ClosePorta", false);
        PortalOpen.Play();
        yield return new WaitForSeconds(portalTime);
        //Play portal closing animation.
        //for loop size of portal background back down.
        //turn off collider object that'll count/yeet the object.
        InnardAnim.SetBool("Shrink", true);
        PortalAnim.SetBool("ClosePorta", true);
        
        PortalClose.Play();
        
        yield return new WaitForSeconds(2f);
        portalCentre.SetActive(false);
        PortalInnard.SetActive(false);
        opened = false;
    }
}
