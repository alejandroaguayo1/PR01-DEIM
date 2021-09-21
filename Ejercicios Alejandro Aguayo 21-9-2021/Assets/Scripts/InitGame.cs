using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InitGame : MonoBehaviour
{
    
    private string nombre = "Alejandro";
    public string nombre1 = "AlejandroA";
    [SerializeField] string nombre2 = "";
    public int x = 1;
    public float y = 2f;
    // Start is called before the first frame update
    void Start()
    {
        print(nombre);
        print(nombre1);
        print(nombre1 + nombre);
        print(x + y);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
