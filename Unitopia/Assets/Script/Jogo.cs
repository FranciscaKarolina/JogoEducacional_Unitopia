using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Jogo : MonoBehaviour
{
    public BarraVida barra;
    private float vida = 100;

    void Start(){
        
    }

    void Update(){
        //vida do jogador
        if(Input.GetKeyDown(KeyCode.Space)){
            vida -= 10.0f;
            barra.AlterarVida(vida);
        }

    }

}
