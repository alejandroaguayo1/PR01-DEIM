using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2b : MonoBehaviour
{
    int x = 0;
    
    // Start is called before the first frame update
    void Start()
    {while (x <10)
        {
            print(x);
            x++;
            

        }
        for (int x = 0; x < 10;)
        {
            print(x);
            x++;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
