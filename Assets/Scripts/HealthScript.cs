using System;
using System.Collections;
using System.Collections.Generic;
using System.Net.Mime;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.UI;

public class HealthScript : MonoBehaviour
{

    public static HealthScript instance;

    public int playerheath = 3;
    public Text HealthPoint;

    public  bool dead=false; 


    public GameObject FailPanel;

    private void Start()
    {

        if(HealthScript.instance == null)
        {
            instance = this ;
        }
        textprop();
    }

    public void textprop()
    {
        HealthPoint.text = playerheath.ToString();
    }
    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Enemey"))
        {
           
            playerheath -= 1;
            textprop();

        }
        if (collision.gameObject.CompareTag("Health"))
        {
            playerheath += 1;
            
            collision.gameObject.SetActive(false);
            textprop();
        }

        if (playerheath == 0 ) 
        {
            SpawnManager.instance.BgAudio.Stop();
            SpawnManager.instance.Audio1.Play();
            Time.timeScale = 0f; 
            dead = true;
            FailPanel.SetActive(true);
            
        }


       
    }

   
}


