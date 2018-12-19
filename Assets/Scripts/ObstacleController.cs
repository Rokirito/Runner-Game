using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Audio;

public class ObstacleController : MonoBehaviour
{
    [SerializeField] private GameObject Obstacle;
    private AudioSource music;
    private bool[] trigger;
    private bool spawnObstacle = false;
    private float value;

    // Start is called before the first frame update
    void Start()
    {
      music = GetComponent<AudioSource>();
      StartCoroutine(GetPositionWithSound());
    }

    // Update is called once per frame
    void Update()
    {
      if (value > 0.5f && value < 2.6f && spawnObstacle == true && Time.time <= music.time + 1 ||
      value > 8.0f && value < 26.0f && spawnObstacle == true && Time.time <= music.time + 1)
      {
          music.panStereo = 0;
          Instantiate(Obstacle, new Vector3(0, 0.5f, 65), transform.rotation);
          value = 0;
          spawnObstacle = false;
      }
      if (value > 2.6f && spawnObstacle == true && Time.time <= music.time + 1 ||
        value > 26.0f && spawnObstacle == true && Time.time <= music.time + 1)
      {
          music.panStereo = 1;
          Instantiate(Obstacle, new Vector3(3.25f, 0.5f, 65), transform.rotation);
          value = 0;
          spawnObstacle = false;
      }
      if (value < 0.5f && spawnObstacle == true && Time.time <= music.time + 1||
      value < 8.0f && spawnObstacle == true && Time.time <= music.time + 1)
      {
          music.panStereo = -1;
          Instantiate(Obstacle, new Vector3(-3.25f, 0.5f, 65), transform.rotation);
          value = 0;
          spawnObstacle = false;
      }


    }
    IEnumerator GetPositionWithSound(){

        float[] spectrum = new float[512];

        AudioListener.GetSpectrumData(spectrum, 0, FFTWindow.Rectangular);

        for (int i = 1; i < spectrum.Length - 1; i++)
        {
            value += spectrum[i] * 10;
            //Debug.Log(value);
        }
        spawnObstacle = true;
        yield return new WaitForSeconds(.5f);
          StartCoroutine(GetPositionWithSound());
    }
}