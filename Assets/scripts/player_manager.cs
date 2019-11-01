using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class player_manager : MonoBehaviour
{
    public int level = 3;
    public int health = 10;

    public void SavePlayer()
    {
        save_system.savePlayer(instance);
       // Debug.Log("saving");
    }

    public void LoadPlayer()
    {
        player_data data = save_system.LoadPlayer();
        //Debug.Log("loading");

        level = data.level;
        health = data.health;

        Vector3 position;
        position.x = data.position[0];
        position.y = data.position[1];
        position.z = data.position[2];

        transform.position = position;
    }
    #region Singleton
    public static player_manager instance { get; private set; }
    //private static player_manager _instance;

    void Awake()
    {
        if (instance == null)
        {
            instance = this;
        }
        else
        {
            Destroy(gameObject);
        }
        
    }
    #endregion

    public GameObject player;

    private void Start()
    {
    }
    private void Update()
    {
        Scene scene = SceneManager.GetActiveScene();

        string Scenename = scene.name;
        if (Scenename == "menu")
        {
            
            Cursor.lockState = CursorLockMode.None;
        }
        else if(Scenename == "level1")
        {
            
            Cursor.lockState = CursorLockMode.Locked;
        }
    }
}
