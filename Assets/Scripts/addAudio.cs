using UnityEditor;
using UnityEngine;


[ExecuteInEditMode]
public class addAudio : MonoBehaviour
{
    
    public GameObject trigger;
    //public GameObject trigger = Instantiate(audiotrigger1) as GameObject;
    public GameObject spawnloc;
    public Transform rot;
    // Start is called before the first frame update
    #region Singleton
    public static addAudio Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }


    #endregion

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Alpha1))
        {
            //Transform newT = Instantiate(trigger, transform.position, transform.rotation);
        }
    }
    [MenuItem("MyMenu/Do Something with a Shortcut Key %g")]
    static void DoSomethingWithAShortcutKey()
    {

        Debug.Log("Doing something with a Shortcut Key...");
        //public GameObject trigger = Instantiate(audiotrigger1) as GameObject;

        addAudio.Instance.spawnItem();

    }

    void spawnItem()
    {
        GameObject a = Instantiate(trigger) as GameObject;
        a.transform.position = new Vector3(spawnloc.transform.position.x, spawnloc.transform.position.y, spawnloc.transform.position.z);
        //GameObject newT = (GameObject)Instantiate(trigger, spawnloc.transform.position, rot.rotation);
    }
}
