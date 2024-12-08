using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnManager : MonoBehaviour
{
    public static SpawnManager instance;
    public GameObject[] Tiles;

    private float start = 1.5f;
    private float restart = 1.3f;



    public AudioSource BgAudio;
    public AudioSource Audio1;

    private void Start()
    {
        instance = this;
      
        InvokeRepeating("Spawn", start, restart);
      
    }

    public void Loop()
    {
        int randomIndex = Random.Range(0, Tiles.Length);
        
        Tiles[randomIndex].SetActive(false);

    }

    public void ActiveLoop()
    {
        foreach (var tile in Tiles)
        {
            tile.SetActive(true);
        }
       
    }

    public void Spawn()
    {
        ActiveLoop();
        Loop();
        Instantiate(Tiles[0], new Vector3(-3.33f, 0.081f, 13f), Quaternion.identity);
        Instantiate(Tiles[1], new Vector3(3.39f, 0.081f, 13f), Quaternion.identity);
        Instantiate(Tiles[2], new Vector3(-1.2f, 0.081f, 13f), Quaternion.identity);
        Instantiate(Tiles[3], new Vector3(0.99f, 0.081f, 13f), Quaternion.identity);
    }
}
