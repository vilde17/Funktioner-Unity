using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class JamforelseOchInmatning : MonoBehaviour
{
    public int MyIntValue = 20;
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            Debug.Log(MyIntValue = (MyIntValue + 2));
        }
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            Debug.Log(MyIntValue = (MyIntValue / 2));
        }
        if (Input.GetKeyDown(KeyCode.UpArrow))
        {
            Debug.Log(MyIntValue);
        }
    }



}
