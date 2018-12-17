using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
    [SerializeField] private GameObject[] building;
    private Vector3 position;   
    private int buildPrefab;

    void Update()
    {
        transform.position -= new Vector3(0, 0, BuildingSpawnController.speed * Time.deltaTime);
        position = transform.position;
        if (position.z <= -10)
        {
            buildPrefab = Random.Range(0, (building.Length-1));
            Instantiate(building[buildPrefab], new Vector3(transform.position.x, transform.position.y, 40), transform.rotation);
            Destroy(this.gameObject);
        }
    }
}