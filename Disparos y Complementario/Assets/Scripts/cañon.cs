using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour
{

    public GameObject proyectil;
    public Transform posicionCannon;


    void Disparo() 
    {
        Instantiate(proyectil, posicionCannon.position, posicionCannon.rotation);
    }

    void Disparo2() // Desafío Complementario
    {
        Disparo();
        Invoke("Disparo", 0.1f);
        //   Instantiate(proyectil, posicionCannon.position, posicionCannon.rotation);
        //   Instantiate(proyectil, (posicionCannon.position + new Vector3 (0.25f, 0,0) ), posicionCannon.rotation);
    }

    void Disparo3() // Desafío Complementario
    {
        Disparo();
        Invoke("Disparo", 0.1f);
        Invoke("Disparo", 0.2f);
        //Instantiate(proyectil, posicionCannon.position, posicionCannon.rotation);
        //Instantiate(proyectil, (posicionCannon.position + new Vector3(0.25f, 0, 0)), posicionCannon.rotation);
        //Instantiate(proyectil, (posicionCannon.position + new Vector3(0.5f, 0, 0)), posicionCannon.rotation);
    }

    void Disparo4() // Desafío Complementario
    {
        Disparo();
        Invoke("Disparo", 0.1f);
        Invoke("Disparo", 0.2f);
        Invoke("Disparo", 0.3f);
        //Instantiate(proyectil, posicionCannon.position, posicionCannon.rotation);
        //Instantiate(proyectil, (posicionCannon.position + new Vector3(0.25f, 0, 0)), posicionCannon.rotation);
        //Instantiate(proyectil, (posicionCannon.position + new Vector3(0.5f, 0, 0)), posicionCannon.rotation);
        //Instantiate(proyectil, (posicionCannon.position + new Vector3(0.75f, 0, 0)), posicionCannon.rotation);
    }

    // Start is called before the first frame update
    void Start()
    {
        // Disparo();       Ya que se dispara con Space se elimino el spawn automatico en el Start, se deja como referencia
    }

    // Update is called once per frame
    void Update()
    {
        // KeyCode Space para cumplir con el Desafío Entregable
        
        if (Input.GetKeyDown(KeyCode.Space)) 
        { 
            Disparo(); 
        }
       // Capturo KeyCodes para Desafio complementario
        if (Input.GetKeyDown(KeyCode.J))
        {
            Disparo2();
        }
        if (Input.GetKeyDown(KeyCode.K))
        {
        Disparo3();
    }
        if (Input.GetKeyDown(KeyCode.L))
        {
        Disparo4();
    }
    }
}
