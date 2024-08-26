using System.Collections;
using System.Collections.Generic;
using UnityEditor;
using UnityEngine;

public class ConsolePrint : MonoBehaviour
{
    int i;
    public Renderer rend;

    // Start is called before the first frame update
    void Start()
    {
        i = 3;
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(gameObject.name + ":" + ++i);
    }
}
