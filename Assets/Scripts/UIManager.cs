using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    [SerializeField] private GameObject scoreObject;
    private float score = 0;
    private Text scoreText;

    private void Start()
    {
        scoreText = scoreObject.GetComponent<Text>();
    }

    // puede recibir un enemy type para modificar el score.
    public void scoreUpdate()
    {
        scoreText.text = "Score: " + score.ToString();
        score += 10;
    }
}