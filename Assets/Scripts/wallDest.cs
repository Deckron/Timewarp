using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class wallDest : MonoBehaviour
{
    // Start is called before the first frame update
    public cube cube;
    void Start()
    {
        
    }

    // Update is called once per frame
    public void OnCollisionEnter(Collision collision)
    {
        if(cube.isDestroyed)
        {
            if(collision.gameObject.tag=="Player")
            {
                Destroy(gameObject);
            }
        }
    }
}
