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

        Vector3 direcao = new Vector3(eixoX, 0, eixoZ);

        // deltaTime retorna o tempo em segundos que a Unity demorou para rodar o último frame, onde no cálculo irá resultar em movimento por segundo
        transform.Translate((direcao * Time.deltaTime) * Velocidade);
    }
}
