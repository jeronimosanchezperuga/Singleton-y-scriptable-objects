using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RelaccionConOtroElemento : MonoBehaviour
{
    public GameObject otroElemento;

    // Start is called before the first frame update
    void Start()
    {
        otroElemento = GameObject.FindGameObjectWithTag("ObjetoLab");

        if (otroElemento != null)
        {
            Debug.Log("está");
            if (otroElemento.GetComponent<Personaje>().personajeData.tieneLaLlave)
            {
                Debug.Log("Tiene la llave");
            }
            else
            {
                Debug.Log("No tiene la llave");
            }
        }
        else
        {
            Debug.Log("NO está");
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
