using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    [SerializeField] private float obstacleSpeed = 20;
    public float newSpeed = 2;

    void Update()
    {
        transform.position -= new Vector3(0f, 0f, (obstacleSpeed * newSpeed) * Time.deltaTime);
        if(transform.position.y <= -10)
            Destroy(this.gameObject);
    }
}