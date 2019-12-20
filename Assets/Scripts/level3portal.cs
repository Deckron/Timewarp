﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class level3portal : MonoBehaviour
{
    public cube mac;
    // Start is called before the first frame update

    void OnTriggerEnter(Collider col)
    {
        if (mac.isDestroyed)
        {
            if (col.gameObject.tag == "Player")
            {
                SceneManager.LoadScene("winScreen", LoadSceneMode.Single);
            }
        }
    }
}
