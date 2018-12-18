using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private GameObject Obstacle;
    private AudioSource music;
    private int musicTimer;
    private bool[] trigger;
    private bool joder=true;

    // Start is called before the first frame update
    void Start()
    {
        music = GetComponent<AudioSource>();
        trigger = new bool[3];
        for(int i = 0; i < 2 ; i++){
            trigger[i] = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        if (music.time >= 4 && trigger[0] == true)
        {
            Debug.Log(music.panStereo);
            music.panStereo = 0;
            Instantiate(Obstacle, new Vector3(0, 0.5f, 65), transform.rotation);
            Debug.Log("1");
            trigger[0] = false;
        }
        if (music.time >= 8 && trigger[1] == true)
        {
            music.panStereo = 1;
            Instantiate(Obstacle, new Vector3(3.25f, 0.5f, 65), transform.rotation);
            Debug.Log("2");
            trigger[1] = false;
        }
        if (music.time >= 12 && joder == true)
        {
            music.panStereo = -1;
            Instantiate(Obstacle, new Vector3(-3.25f, 0.5f, 65), transform.rotation);
            Debug.Log("3");
            joder = false;
        }
    }
}