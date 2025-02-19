using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MainMenuScript : MonoBehaviour
{
    public GameObject CreditsCanvas;
    public GameObject MainMenuCanvas;


    void Start()
    {
        CreditsCanvas.SetActive(false);
        MainMenuCanvas.SetActive(true);
    }

    void Update()

    {

    }


    public void PlayButton()
    {
        UnityEngine.SceneManagement.SceneManager.LoadScene("GameLevel");
    }

    public void CreditsButton() 
    { 
        CreditsCanvas.SetActive(true);
        MainMenuCanvas.SetActive(false);
    }

    public void QuitButton()
    {
        Application.Quit();
    }
}
