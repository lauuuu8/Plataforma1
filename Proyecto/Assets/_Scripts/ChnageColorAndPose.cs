using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ChnageColorAndPose : MonoBehaviour
{
    private SpriteRenderer renderer;
    public GameObject blueCircle;

    // Start is called before the first frame update
    void Start()
    {
        renderer = GetComponent<SpriteRenderer>();
        transform.position = blueCircle.transform.position;
        ChangeColor();

        Vector3 pos = transform.position;
        Debug.Log("La posicion del circulo es: (" + pos.x + ", " + pos.y + ", " + pos.z + ") y su color es Azul");

    
    }

    public void ChangeColor(){
    renderer.color = Color.cyan;


    }
   
}
