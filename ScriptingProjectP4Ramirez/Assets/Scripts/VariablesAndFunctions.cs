using System.Collections;
using System.Collections.Generic;
using System.Globalization;
using UnityEngine;

public class VariablesAndFunctions : MonoBehaviour
{
    //Create a variable of type int
    int myInt = 5;

    // Start is called before the first frame update
    void Start()
    {
        myInt = MultiplyByTwo(myInt);
        Debug.Log(myInt);
    }


    int MultiplyByTwo(int number)
    {
        int result;
        result = number * 2;
        return result;
    }

    // Update is called once per frame
    void Update()
    {

    }
  
}
