using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ColetaFrasco : MonoBehaviour
{
    public Text textoPontuacao; // Referência ao componente de texto
    public int pontuacaoTotal = 0;
    public int pontuacaoMaxima = 40;
    public int maximoFrascos = 6;
    private int frascosColetados = 0;

    public void ColetarFrasco(int valor)
    {
        if (pontuacaoTotal + valor <= pontuacaoMaxima && frascosColetados < maximoFrascos)
        {
            pontuacaoTotal += valor;
            frascosColetados++;
        }
    }

    void UpdatePontuacaoTotal(int novaPontuacao)
    {
        pontuacaoTotal += novaPontuacao;
        textoPontuacao.text = "Pontuação: " + pontuacaoTotal.ToString(); // Atualiza o texto
    }
}
    
