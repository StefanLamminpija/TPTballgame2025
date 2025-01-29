using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class PlayerController : MonoBehaviour 
{

    public float Speed;
    public Text ScoreText;
    public Text WinText;
    public GameObject Gate;
    private Rigidbody rb;
    public int Score;

    void SetScoreText()
    {
        ScoreText.text = "Score: " + Score.ToString();

        if (Score >= 5) 
        {
            WinText.text = "You Won! Press R to restart or ESC to quit";
        }

    }

    void Start()
    {
        rb = GetComponent<Rigidbody>();
        Score = 0;
        SetScoreText();
        WinText.text = "";
    }


    void Update()
    {
        float moveHorizontal = Input.GetAxis("Horizontal");
        float moveVertical = Input.GetAxis("Vertical");

        Vector3 movement = new Vector3(moveHorizontal, 0.0f, moveVertical);

        rb.AddForce(movement * Speed);

        // Restart
        if (Input.GetKeyDown(KeyCode.R))
        {
            Application.LoadLevel(Application.loadedLevel);
        }

    }
}
