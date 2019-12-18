using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class audioMan : MonoBehaviour
{
    // Start is called before the first frame update

    public static audioMan Instance { get; private set; }
    private void Awake()
    {
        Instance = this;
    }
}
