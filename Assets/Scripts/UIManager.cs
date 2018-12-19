using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    private float score = 0;
    [SerializeField] private Text scoreText;

    private void Start()
    {
    }

    // puede recibir un enemy type para modificar el score.
    public void scoreUpdate()
    {
        scoreText.text = "Score: " + score.ToString();
        score += 10;
    }
}