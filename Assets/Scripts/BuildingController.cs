using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BuildingController : MonoBehaviour
{
    [SerializeField] private GameObject[] buildingPrefabs;
    [SerializeField] private GameObject[] enviromentPrefabs;
    private GameObject buildingParents;
    private GameObject enviromentParents;
    private GameObject newBuildPrefab;
    private GameObject newEnviromentPrefab;
    private int randomEnviromentNumber;
    internal bool buildingIsDead;
    internal bool enviromentIsDead;
    public float nextTimeSpawnEnviroment;
    public float timeBetweenSpawns;


    void Start(){
      buildingParents = GameObject.FindGameObjectWithTag("Building");
      enviromentParents = GameObject.FindGameObjectWithTag("Enviroment");
      SpawnBuilding();
    }

    void Update(){
      if (buildingIsDead){
        SpawnBuilding();
       }
     if(Time.time >= nextTimeSpawnEnviroment){
        nextTimeSpawnEnviroment = Time.time + timeBetweenSpawns;
        SpawnEnviroment();
     }
    }

    public void SpawnBuilding(){
        for(int i = 0; i <= buildingPrefabs.Length-1; i++){
          newBuildPrefab = Instantiate(buildingPrefabs[i], buildingPrefabs[i].transform.position, buildingPrefabs[i].transform.rotation);
          newBuildPrefab.transform.parent = buildingParents.transform;
        }
        buildingIsDead = false;
    }

      public void SpawnEnviroment(){
        randomEnviromentNumber = Random.Range(0, (enviromentPrefabs.Length-1));
        newEnviromentPrefab = Instantiate(enviromentPrefabs[randomEnviromentNumber], enviromentPrefabs[randomEnviromentNumber].transform.position, enviromentPrefabs[randomEnviromentNumber].transform.rotation);
        newEnviromentPrefab.transform.parent = enviromentParents.transform;
        enviromentIsDead = false;
    }
}
