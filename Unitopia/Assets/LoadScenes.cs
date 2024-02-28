using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class LoadScenes : MonoBehaviour
{
    //Menu
    public void MenuScene(){
        SceneManager.LoadScene("Menu");
    }

    public void Options()
    {
        SceneManager.LoadScene("Options");
    }
    public void Creditos()
    {
        SceneManager.LoadScene("Creditos");
    }
    public void SelectLevel()
    {
        SceneManager.LoadScene("SelectLevel");
    }
    public void QuitGame()
    {
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
