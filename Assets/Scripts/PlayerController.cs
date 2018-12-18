using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    //[SerializeField] private float playerSpeed = 15f;
    //private float xMovement;

    void Update()
    {
        if (Input.GetAxisRaw("Horizontal") == 1){
            transform.position = new Vector3(3, 0.5f, -2f);
        }
        else if (Input.GetAxisRaw("Horizontal") == -1){
            transform.position = new Vector3(-3, 0.5f, -2f);
        }
        else{
            transform.position = new Vector3(0, 0.5f, -2f);
        }
    }
}
