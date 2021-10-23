using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class MenuButtons : MonoBehaviour
{
    [SerializeField] GameObject player, points, spawner;
    [SerializeField] TextMeshProUGUI highscrore;
    public void Startgame()
    {
        player.SetActive(true);
        points.SetActive(true);
        spawner.SetActive(true);
        gameObject.SetActive(false);
    }

    public void ResetScore()
    {
        PlayerPrefs.SetInt("Highscrore", 0);
        highscrore.text = "Highscrore: " + PlayerPrefs.GetInt("Highscrore");
    }
}
