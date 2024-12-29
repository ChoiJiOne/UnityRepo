using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Script28 : MonoBehaviour
{
    int Add(int a, int b)
    {
        int c = a + b;
        return c;
    }

    // Start is called before the first frame update
    void Start()
    {
        int answer;
        int num1 = 2;
        int num2 = 3;
        answer = Add(num1, num2);
        Debug.Log(answer);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
