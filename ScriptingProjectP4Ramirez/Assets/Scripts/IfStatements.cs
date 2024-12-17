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
        if (Input.GetKey(KeyCode.Space))
            TemperatureTest(); 

        coffeeTemperature -= Time.deltaTime * 5f;
    }

    // Update is called once per frame
    void TemperatureTest()
    {
        //If the coffee's temperature is greater than the hottest drinking temperature...
        if (coffeeTemperature > hotLimitTemperature)
        {
            //... do this.
            print("AAAAAAH! The coffee is burning hot!");
        }
        //if it isn't, but the coffee temperature is less than the coldest drinking temperature...
        else if (coffeeTemperature < coldLimitTemperature)
        { //...do this.
            print("BRRRRR! Coffee is freezing, yuck!");
        }
        //If it is neither of those then...
        else
        {
            //...do this.
            print("Coffee is just right.");
        }
    }


    }

