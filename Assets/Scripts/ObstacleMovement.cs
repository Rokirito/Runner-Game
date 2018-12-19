using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 20;
    public float newSpeed = 2;
    private bool scoreTrigger = true;

    void Update()
    {
        transform.position -= new Vector3(0f, 0f, (obstacleSpeed * newSpeed) * Time.deltaTime);
        if (transform.position.z <= -3 && scoreTrigger == true)
        {
            GameObject.FindGameObjectWithTag("UIManager").GetComponent<UIManager>().scoreUpdate();
            scoreTrigger = false;
        }
            
        if (transform.position.z <= -15)
            Destroy(this.gameObject);
    }
}