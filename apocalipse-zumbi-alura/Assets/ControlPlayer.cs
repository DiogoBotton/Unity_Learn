using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ControlPlayer : MonoBehaviour
{
    public float Velocidade = 10;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float eixoX = Input.GetAxis("Horizontal");
        float eixoZ = Input.GetAxis("Vertical");
        bool andar = Input.GetKey(KeyCode.LeftShift);

        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);


        if(direcao != Vector3.zero)
        {
            if (andar)
            {
                GetComponent<Animator>().SetBool("Andando", true);
                GetComponent<Animator>().SetBool("Correndo", false);
                Velocidade = 5;
            }
            else
            {
                GetComponent<Animator>().SetBool("Correndo", true);
                GetComponent<Animator>().SetBool("Andando", false);
                Velocidade = 10;
            }

        }
        else
        {
            GetComponent<Animator>().SetBool("Correndo", false);
            GetComponent<Animator>().SetBool("Andando", false);
        }

        // deltaTime retorna o tempo em segundos que a Unity demorou para rodar o �ltimo frame, onde no c�lculo ir� resultar em movimento por segundo
        transform.Translate((direcao * Time.deltaTime) * Velocidade);
    }
}
