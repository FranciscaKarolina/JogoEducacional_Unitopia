using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2d : MonoBehaviour
{
    public Rigidbody2D rb;
    public int moveSpeed;
    private float direction;

    private Vector3 facinRight;
    private Vector3 facinLeft;

    public bool taNoChao;
    public Transform detectaChao;
    public LayerMask oQueEhChao;

    public int pulosExtras = 1;

    void Start()
    {
        //Personagem virar para a direita//
        facinRight = transform.localScale;
        //Personagem virar para a direita//
        facinLeft = transform.localScale;
        facinLeft.x = facinLeft.x * -1; //O comando inverte os sinais, por isso o uso de *
        rb = GetComponent<Rigidbody2D>(); 
    }
    void Update()
    { 
        taNoChao = Physics2D.OverlapCircle(detectaChao.position, 0.2f, oQueEhChao);
        if(Input.GetButtonDown("Jump") && taNoChao == true)
        {
            rb.velocity = Vector2.up * 12;
        }
        if(Input.GetButtonDown("Jump") && taNoChao == false && pulosExtras >0)
        {
            rb.velocity = Vector2.up * 12;
            pulosExtras--;
        }
        if(taNoChao){
            pulosExtras = 1;
        }

        direction = Input.GetAxis("Horizontal");
        if(direction > 0){
            //olhando para a direita
            transform.localScale = facinRight;
        }
        if(direction < 0){
            //olhando para a esquerda
            transform.localScale = facinLeft;
        }

        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
    }
}
