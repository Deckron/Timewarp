using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class displacementControl : MonoBehaviour
{
    public float dis_Amount;
    //public ParticleSystem plosion;
    MeshRenderer Render;
    void Start()
    {
        Render = GetComponent<MeshRenderer>();
    }

    // Update is called once per frame
    void Update()
    {
        
        Render.material.SetFloat("_amount", dis_Amount);
        if (Input.GetButtonDown("Jump"))
        {
            dis_Amount = .8f;
            

        }
    }
}
