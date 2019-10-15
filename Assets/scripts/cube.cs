using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cube : MonoBehaviour
{
    public bool isDestroyed = false;
    private void Start()
    {
        Debug.Log("cube script");
    }
    public void OnTriggerEnter(Collider col)
    {
        Debug.Log("destroyed");
        if (col.gameObject.tag == "Player")
        {
            isDestroyed = true;
            Destroy(gameObject);
        }
    }
}
