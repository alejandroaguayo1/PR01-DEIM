using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2 : MonoBehaviour
{
    int x = 0;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        x++;
        print(x);
        if (x < 1000)
        {
            print(x);
        }
        else
        {
            print("Fin");
        }
    }    
}
