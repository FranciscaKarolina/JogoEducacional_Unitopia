using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    [SerializeField] private string nomeDoLevelDoJogo;
    [SerializeField] private GameObject painelMenuInicial;
    [SerializeField] private GameObject painelOpcoes;
    public void MenuScene(){
        SceneManager.LoadScene("Menu");
    }
    public void Jogar (){
        SceneManager.LoadScene(nomeDoLevelDoJogo);
    }
    public void AbrirOptions()
    {
        painelMenuInicial.SetActive(false);
        painelOpcoes.SetActive(true);
    }
    public void FecharOptions()
    {
        painelMenuInicial.SetActive(true);
        painelOpcoes.SetActive(false);
    }
    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }
    public void QuitGame()
    {
        Debug.Log("Sair do jogo");
        Application.Quit();
    }
    
    //ALL LEVELS
    public void Fase1(){
        SceneManager.LoadScene("Fase1");
    }
    public void Fase2(){
        SceneManager.LoadScene("Fase2");
    }
    public void Fase3(){
        SceneManager.LoadScene("Fase3");
    }
}
