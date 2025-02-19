using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CreditCanvasScript : MonoBehaviour
{

    public GameObject CreditsCanvas;
    public GameObject MainMenuCanvas;

    void Start()
    {

    }

    // Update is called once per frame 

    void Update()
    {
        
    }

    public void BackButton() 
    {
        MainMenuCanvas.SetActive(false);
        CreditsCanvas.SetActive(false);
    }

}
