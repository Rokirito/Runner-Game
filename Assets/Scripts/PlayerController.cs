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
        if (Input.GetAxisRaw("Horizontal") == -1){
            transform.position = new Vector3(-3, 0.5f, -2f);
        }
        if (Input.GetAxisRaw("Vertical") == -1)
        {
            transform.position = new Vector3(0, 0.5f, -2f);
        }
    }

    private void OnTriggerEnter(Collider Obstacle)
    {
        if (Obstacle.GetComponent<Collider>().tag == "Obstacle")
        {
            Debug.Log("Perdiste");
        }
    }
}