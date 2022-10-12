using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Personaje : MonoBehaviour
{

    public int puntaje;
    public PersonajeSO personajeData;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    void OnMouseDown()
    {
        personajeData.tieneLaLlave = !personajeData.tieneLaLlave;
    }

}
