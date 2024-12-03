using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class IfStatements : MonoBehaviour
{
    float coffeeTemperature = 85.0f;
    float hotLimitTemperature = 70.0f;
    float coldLimitTemperature = 40.0f;
 
    // Start is called before the first frame update
    void Update()
    {
        if(Input.GetKey)
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        //    TemperatureTest();
        coffeeTemperature -= Time.deltaTime * 5f;
    }


    }

