using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SwapScene : MonoBehaviour
{
    public string sceneToLoad;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void OnEnable()
    {
        SceneManager.LoadScene(sceneToLoad);
    }
}
