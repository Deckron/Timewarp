using UnityEngine;
using UnityEditor;
using UnityEngine.UI;

public class nar_window : EditorWindow
{
    string myString = "Hello Wold";
    public Object obj;
    
    public AudioClip sound1;
    AudioSource audio;
    [MenuItem("Window/Narrative")]

    

    public static void ShowWindow()
    {
        EditorWindow.GetWindow<nar_window>("Narrative");
    }

    void OnGUI()
    {
        GUILayout.Label("this is a label", EditorStyles.boldLabel);
        myString=EditorGUILayout.TextField("name", myString);
        obj = EditorGUILayout.ObjectField(obj,typeof(Object),true);
        if (GUILayout.Button("Press me"))
        {
            Debug.Log("button was pressed");
        }
    }
    

}