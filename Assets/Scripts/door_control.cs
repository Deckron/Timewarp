using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class door_control : MonoBehaviour
{
    Transform target;
    void Start()
    {
        target = player_manager.instance.player.transform;

    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
