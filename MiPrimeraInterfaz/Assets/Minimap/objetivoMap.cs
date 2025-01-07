using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class objetivoMap : MonoBehaviour
{
    public Transform target; //A quien señalo
    public Transform marcador; //el marcador
    public Transform camara_minimapa; // la cámara que apunta hacia abajo
    public float distanciaMaxima = 10; //el radio de nuestro minimapa redondo
    public Transform map_obj; //el objeto mapa en si

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        transform.position = new Vector3(camara_minimapa.position.x, map_obj.position.y + 0.1f, camara_minimapa.position.z);

        transform.LookAt(new Vector3 (target.position.x, transform.position.y, target.position.z));

        float dist = Vector3.Distance(new Vector3(camara_minimapa.position.x,0, camara_minimapa.position.z), new Vector3(target.position.x, 0, target.position.z));
        
        
        if (dist > distanciaMaxima)
        {

            marcador.position = transform.position + (transform.forward * distanciaMaxima);


        }
        else
        {

            marcador.position = new Vector3(target.position.x, map_obj.position.y + 0.1f, target.position.z);



        }
    }
}
