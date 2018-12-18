using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameMovement : MonoBehaviour
{
    private const int worldSpeed = 10;
    private BuildingController controller;

    void Start()
    {
      controller = GameObject.FindObjectOfType<BuildingController> ();
    }

    void Update()
    {
      transform.Translate(Vector3.back * worldSpeed * Time.deltaTime);
      if(transform.position.z <= -60){
        controller.buildingIsDead = true;
        Destroy(this.gameObject);
      }
    }
}
