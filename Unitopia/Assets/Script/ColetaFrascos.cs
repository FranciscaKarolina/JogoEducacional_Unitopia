using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ColetaFrasco : MonoBehaviour
{
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
}
    
