using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Move2d : MonoBehaviour
{
    public Rigidbody2D rb;
    public Animator animacao;
    public int moveSpeed;
    private float direction;

    private Vector3 facinRight;
    private Vector3 facinLeft;

    public bool taNoChao;
    public Transform detectaChao;
    public LayerMask oQueEhChao;

    public int pulosExtras = 1;

    public int coletaveis;

    void Start()
    {
        //Personagem virar para a direita//
        facinRight = transform.localScale;
        //Personagem virar para a direita//
        facinLeft = transform.localScale;
        facinLeft.x = -facinLeft.x; //O comando inverte os sinais, por isso o uso de *
        rb = GetComponent<Rigidbody2D>();

        animacao = GetComponent<Animator>();
    }
    void Update()
    { 
        //pular
        taNoChao = Physics2D.OverlapCircle(detectaChao.position, 0.2f, oQueEhChao);
        // Define o parâmetro "Pulando" da animação
        animacao.SetBool("Pulando", !taNoChao);

        // Verifica a entrada do jogador para pular
        if(Input.GetButtonDown("Jump") && (taNoChao || pulosExtras > 0))
        {
            rb.velocity = Vector2.up * 18;
            pulosExtras -= 1;
        }

        //direção do jogador
        direction = Input.GetAxis("Horizontal");
        if(direction > 0){
            //olhando para a direita
            transform.localScale = facinRight;
        }
        if(direction < 0){
            //olhando para a esquerda
            transform.localScale = facinLeft;
        }
        // Aplica a velocidade ao jogador
        rb.velocity = new Vector2(direction * moveSpeed, rb.velocity.y);
        
        animacao.SetFloat("Velocidade", Mathf.Abs(direction));
    }
    public ColetaFrasco coletaFrascos;
    private void OnTriggerEnter2D(Collider2D collision){
        if (collision.gameObject.CompareTag("valor2"))
        {
            coletaFrascos.ColetarFrasco(2);
        }
        else if (collision.gameObject.CompareTag("valor4"))
        {
            coletaFrascos.ColetarFrasco(5);
        }
        else if (collision.gameObject.CompareTag("valor5"))
        {
            coletaFrascos.ColetarFrasco(4);
        }
        else if (collision.gameObject.CompareTag("valor8"))
        {
            coletaFrascos.ColetarFrasco(8);
        }
        else if (collision.gameObject.CompareTag("valor10"))
        {
            coletaFrascos.ColetarFrasco(10);
        }

        Destroy(collision.gameObject);

    }
}
