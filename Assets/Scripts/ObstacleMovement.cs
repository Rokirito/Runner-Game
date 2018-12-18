using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleMovement : MonoBehaviour
{
    void Update()
    {
        transform.position -= new Vector3(0, 0, (BuildingSpawnController.speed*2) * Time.deltaTime);
        if(transform.position.y <= -10)
            Destroy(this.gameObject);
    }

    private void OnTriggerEnter(Collider player)
    {
        if (player.GetComponent<Collider>().tag == "Player")
        {
            Debug.Log("Perdiste");
        }
    }
}
