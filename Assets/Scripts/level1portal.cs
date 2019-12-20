using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class level1portal : MonoBehaviour
{
    public cube mac;
    // Start is called before the first frame update
    void OnCollisionEnter(Collision col)
    {
        if (mac.isDestroyed)
        {
            if (col.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("level2", LoadSceneMode.Single);
            }
        }
    }
}
