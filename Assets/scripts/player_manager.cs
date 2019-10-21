using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class player_manager : MonoBehaviour
{
    public int level = 3;
    public int health = 10;

    public void SavePlayer()
    {
        save_system.savePlayer(this);

    }

    public void LoadPlayer()
    {
        player_data data = save_system.LoadPlayer();

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];
    }
    #region Singleton
    public static player_manager instance;

    void Awake()
    {
        instance = this;
    }
    #endregion

    public GameObject player;

    private void Start()
    {
         
    }
}
