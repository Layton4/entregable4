using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColorManager : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public Color RandomColor() //función para generar un color aleatorio usando un vector con coordenadas asociadas a los niveles de RGB (Red, Green, Blue)
    {
       return new Color(Random.Range(0f, 1f), Random.Range(0f, 1f), Random.Range(0f, 1f));
    }

    public Vector3 RandomScale() //función para generar un vector3 aleatorio
    {
        return new Vector3(Random.Range(-1f, 1f), Random.Range(-1f, 1f), Random.Range(-1f, 1f)); //generamos aleatoriamente las 3 coordenadas entre -1 y 1 ambos incluidos.
    }

    public Vector3 RandomPosition() //función para generar un vector3 con 1 coordenada fija y dos valores aleatorios que usaremos para convertirlo en la posión de nuestro gameobject.
    {
        return new Vector3(Random.Range(-5f, 5f), Random.Range(-5f, 5f), 0);
    }

    private void OnMouseDown() //cuando hagamos clic en el colider del gameobject que tiene el script ocurrirá lo que escribimos acontinuación
    {
        GetComponent<MeshRenderer>().material.color = RandomColor(); //cambio aleatorio de color 
        transform.localScale = RandomScale(); //cambio aleatorio de escala
        transform.position = RandomPosition(); //cambio aleatorio de posición
    }
}
