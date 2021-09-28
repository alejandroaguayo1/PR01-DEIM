using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2c : MonoBehaviour
{

    int x = 0;
    bool alive;
    int y = 5;
    // Start is called before the first frame update
    void Start()
    {
        if (alive)
        {
            print(x);
                   
        }
        else if(alive == true)
        {
            print("Hola");

        }
        if (x < 10)
        {
            print(x + 10);

        }
        else if (x > 10)
        {
            print(x - y);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
