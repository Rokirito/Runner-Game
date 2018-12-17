using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    [SerializeField] private float playerSpeed = 15f;
    private float xMovement;

    void Update()
    {
        if(transform.position.x >= -4 && transform.position.x <= 4)
        {
            xMovement = Input.GetAxisRaw("Horizontal") * playerSpeed * Time.deltaTime;
            transform.position = new Vector3(transform.position.x + xMovement, transform.position.y, transform.position.z);
        }
        if (transform.position.x > 4)
            transform.position = new Vector3(4, transform.position.y, transform.position.z);
        if (transform.position.x < -4)
            transform.position = new Vector3(-4, transform.position.y, transform.position.z);
    }
}
