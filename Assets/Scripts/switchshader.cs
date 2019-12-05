using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class switchshader : MonoBehaviour
{
    Shader shader1;
    Shader shader2;
    Renderer rend;
    public cube cube;
    // Start is called before the first frame update
    void Start()
    {
        rend = GetComponent<Renderer>();
        shader1 = Shader.Find("DeepBlue_snaps002");
        shader2 = Shader.Find("new_shader");
        
    }

    // Update is called once per frame
    void Update()
    {
        if (cube.isDestroyed)
        {
            if(rend.material.shader == shader1)
            {
                rend.material.shader = shader2;
            }
            else
            {
                rend.material.shader = shader1;
            }
        }
    }
}
