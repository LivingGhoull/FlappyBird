using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.Audio;

public class PlayerCollisonPipe : MonoBehaviour
{

    [SerializeField] TextMeshProUGUI points;
    [SerializeField] GameObject gameover, spawnPipes;
    [SerializeField] AudioSource[] pointAudio;
    GameObject[] pipes;
    public int count;
    bool dead = true;

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.tag == "Point")
        {
            pointAudio[0].Play();
            count++;
            points.text = "Points: " + count;
        }
        else if (collision.gameObject.tag == "Dead")
        {
            if (dead)
            {
                pointAudio[1].Play();
                dead = false;
            }

            gameObject.GetComponent<MakeBirdJump>().enabled = false;
            spawnPipes.SetActive(false);
            gameover.SetActive(true);
            pipes = GameObject.FindGameObjectsWithTag("Pipe");
            foreach(GameObject pipe in pipes)
            {
                pipe.GetComponent<PipeMovement>().speed = 0;
            }
            
           
        }
    }
}
