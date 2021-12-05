using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuScript : MonoBehaviour
{
    public GameObject StartMenuCanvas;
    public GameObject CreditsCanvas;
    // Start is called before the first frame update
    void Start()
    {

    }
    public void StartGame() {
        SceneManager.LoadScene("room");
    }
    public void ShowCredits() {
        CreditsCanvas.SetActive(true);
        StartMenuCanvas.SetActive(false);
    }
    public void QuitGame() {
        Application.Quit();
    }
    public void BackToMainMenu() {
        StartMenuCanvas.SetActive(true);
        CreditsCanvas.SetActive(false);
    }
}
