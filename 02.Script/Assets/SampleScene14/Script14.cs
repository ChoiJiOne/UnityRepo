using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script14 : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        //int hp = 200;
        int hp = 0;
        if(hp > 100)
        {
            Debug.Log("����!");
        }
        else
        {
            Debug.Log("���!");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}