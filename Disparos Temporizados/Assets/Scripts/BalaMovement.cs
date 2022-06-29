using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BalaMovement : MonoBehaviour
{

    public Vector3 direction = new Vector3(-1, 0, 0);
    public float speed = 2.0f;
    public int damage = 5;
    public float bulletTimeToLive = 10.0f;
    public Vector3 nuevaEscala = new Vector3(2, 2, 2);


    // Start is called before the first frame update
    void Start()
    {
      
    }

    // Update is called once per frame
    void Update()
    {
        transform.position += direction * Time.deltaTime * speed;
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Vector3 v = transform.localScale;
            transform.localScale = Vector3.Scale(v, nuevaEscala);
            // Según consigna "Si pulsamos la barra espaciadora, las balas deben duplicar su escala actual."
            //Entiendo que aplica a las balas ya spawneadas mientras las otras salen a escala normal. Si tienen que ser todas las instanciadas
            // avisame asi cambio el script al cañon para que las instancie duplicadas

        }
        Destroy(gameObject, bulletTimeToLive);
       
    }
}
