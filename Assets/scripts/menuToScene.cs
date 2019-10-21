using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class menuToScene : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Numlock))
        {
            Debug.Log("button pressed");
            SceneManager.LoadScene("level1", LoadSceneMode.Single);
        }
    }

    
}
