using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class cañon : MonoBehaviour
{

    public GameObject proyectil;
    public Transform posicionCannon;
    public float bulletStart = 3.0f;
    float temporizador;


    void Disparo() 
    {
        Instantiate(proyectil, posicionCannon.position, posicionCannon.rotation);
    }


    

    void Disparo2() 
    {
        Disparo();
        Invoke("Disparo", 0.1f);

    }

    void Disparo3() 
    {
        Disparo();
        Invoke("Disparo", 0.1f);
        Invoke("Disparo", 0.2f);

    }

    void Disparo4() 
    {
        Disparo();
        Invoke("Disparo", 0.1f);
        Invoke("Disparo", 0.2f);
        Invoke("Disparo", 0.3f);
       
    }

    // Start is called before the first frame update
    void Start()
    {
        // Desafio disparos temporizados.Guardo el valor del tiempo para poder resetear en el update
        temporizador = bulletStart;
    }

    // Update is called once per frame
    void Update()
    {

     // Desafio disparos temporizados.    

        if (bulletStart <= 0)
        {
            Disparo();
            bulletStart = temporizador;
        }
        else
        {
            bulletStart -= Time.deltaTime;

        }
      //  Debug.Log(bulletStart);
      //  Debug.Log(temporizador);





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
