using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class sceneToMenu : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    void Update()
    {

        if (Input.GetKeyDown(KeyCode.Numlock))
        {
            Debug.Log("button pressed");
            SceneManager.LoadScene("menu", LoadSceneMode.Single);
        }
    }


}
