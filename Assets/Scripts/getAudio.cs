using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class getAudio : MonoBehaviour
{
    public GameObject trigger;
    public GameObject spawnloc;
    public Transform rot;
    // Start is called before the first frame update
    public static getAudio Instance { get; private set; }
    private void Awake()
    {
        if(Instance == null)
        {
            Instance = this;
        }
    }
    void Start()
    {
        
    }
    public GameObject spawnItem()
    {
        GameObject a = Instantiate(trigger) as GameObject;
        a.transform.position= a.transform.position = new Vector3(spawnloc.transform.position.x, spawnloc.transform.position.y, spawnloc.transform.position.z);
        return a;
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
