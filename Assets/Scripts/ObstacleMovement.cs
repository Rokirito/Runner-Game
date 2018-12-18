using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    private const int worldSpeed = 20;

    void Update()
    {
        transform.position -= new Vector3(0, 0, (worldSpeed * 2) * Time.deltaTime);
        if(transform.position.y <= -10)
            Destroy(this.gameObject);
    }
}
