using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class reloj : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine("Encendidoreloj");
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    IEnumerator Encendidoreloj()
    {

        int segundos = 0;
        int minutos = 0;
        int horas = 0;
        string textoreloj;
        
        for(int n = 0; ; n++)
        {
            print(n);
            segundos++;
            if(segundos > 59)
            {
                minutos++;
                segundos = 0;
            }
            if(minutos > 59)
            {
                horas++;
                minutos = 0;
            }
            

            textoreloj = horas.ToString("02") + ":" + minutos.ToString("02") + ":" + segundos.ToString("02");
            yield return new WaitForSeconds(1f);
        }
    }

}
