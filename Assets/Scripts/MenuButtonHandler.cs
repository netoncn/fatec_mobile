using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuButtonHandler : MonoBehaviour{

    public Scenes.SceneNames scene;
    public GameObject menuAtual;
    public GameObject menuNovo;

    public void LoadLevel() {
        SceneManager.LoadScene(scene.ToString());
    }

    public void Sair() {
        Application.Quit();
    }

    public void AcessarMenu() {
        menuAtual.SetActive(false);
        menuNovo.SetActive(true);
    }
}
