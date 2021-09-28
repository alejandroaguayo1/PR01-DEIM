using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ejercicio4a2 : MonoBehaviour
{ bool encendido = false; 
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if(encendido == false)
            {
                StartCoroutine("contador");
            }
        }
        if (Input.GetKeyDown(KeyCode.Return))
        {
            if (encendido == true)
            {
                StopCoroutine("contador");
            }
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
}
