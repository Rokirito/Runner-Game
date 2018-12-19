using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{
    public static float score = 0;
    [SerializeField] private GameObject scoreObject;
    private Text scoreText;

    // Start is called before the first frame update
    void Start()
    {
        scoreText = scoreObject.GetComponent<Text>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log(score);
    }

    // puede recibir un enemy type para modificar el score.
    public void scoreUpdate()
    {
        scoreText.text = "Score: " + score.ToString();
        score += 10;
    }
}
