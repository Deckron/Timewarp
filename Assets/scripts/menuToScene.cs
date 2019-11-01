using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class menuToScene : MonoBehaviour
{
    public Button save;
    public Button load;

    // Start is called before the first frame update
    void Start()
    {
        Button save_btn = save.GetComponent<Button>();
        Button load_btn = load.GetComponent<Button>();
        save_btn.onClick.AddListener(TaskOnClick1);
        load_btn.onClick.AddListener(TaskOnClick2);
    }

    void TaskOnClick1()
    {
        player_manager.instance.SavePlayer();
        Debug.Log("save button pressed");
    }

    void TaskOnClick2()
    {
        player_manager.instance.LoadPlayer();
        Debug.Log("load button pressed");
    
    }

    void Update()
    {
        
        if(Input.GetKeyDown(KeyCode.Numlock))
        {
            Debug.Log("button pressed");
            SceneManager.LoadScene("level1", LoadSceneMode.Single);
        }

    }

    
}
