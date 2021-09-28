using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ejercicio2d : MonoBehaviour
{//4a 2
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("contador");
    }
    

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.Space))
        {
            StartCoroutine("contador");
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            StopCoroutine("contador");
        }
        {
            IEnumerator contador()
            {
              
                for (int n = 0; n++)
                {
                    print(n);
                    yield return new WaitForSeconds(1f);
                }

            }
        }
    }
}
//bool
