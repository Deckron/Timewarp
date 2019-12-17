using UnityEditor;
using UnityEngine;


[ExecuteInEditMode]
public class addAudio : MonoBehaviour
{
    
    public GameObject trigger;
    public static GameObject spawnloc;
    public static Transform rot;
    // Start is called before the first frame update
    void Start()
    {
        
    }

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
        public static GameObject useTrig = trigger;
        Debug.Log("Doing something with a Shortcut Key...");
        //public GameObject trigger = Instantiate(audiotrigger1) as GameObject;

        Instantiate(trigger, spawnloc.transform.position, rot.rotation);
    }

    void spawnItem()
    {
        
    }
}
