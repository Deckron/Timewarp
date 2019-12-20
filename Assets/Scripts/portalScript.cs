using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class portalScript : MonoBehaviour
{
    public bool testBool;
    Shader shader1;
    Shader shader2;
    public Material mat1;
    public Material mat2;
    public cube mac;
    
    Renderer rend;
    void Start()
    {
        testBool = false;
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("aura");
        shader2 = Shader.Find("aura");
        rend.material = mat1;
    }

    // Update is called once per frame
    void Update()
    {
        if (mac.isDestroyed)
        {
            rend.material = mat2;
        }
    }
}
