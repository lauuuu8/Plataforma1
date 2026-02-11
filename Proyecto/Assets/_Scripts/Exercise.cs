using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Exercise : MonoBehaviour
{
    // Creacion variables
    [Header("Numeros")]

    public int a;
    public int b;
    private int result;
    public string textName;


    // Start is called before the first frame update
    void Start()
    {
        Suma();
    }
    // suma de dos numeros
    public void Suma(){
        result = a + b;

        // escribe resultado en consola
        Debug.Log("El resultado es: " + result);
        Debug.Log(string.Format("El {0} es {1}", textName, result));


    }
}
