using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class RestartGame : MonoBehaviour
{
    [SerializeField] PlayerCollisonPipe playerData;
    [SerializeField] TextMeshProUGUI highscore;
    

    private void Awake()
    {
        if(PlayerPrefs.GetInt("Highscrore") == 0)
        {
           PlayerPrefs.SetInt("Highscrore", 0);
        }
        else
        {
            highscore.text = "HighScrore: " + PlayerPrefs.GetInt("Highscrore");
        }
    }

    public void Restart()
    {
        if(playerData.count > PlayerPrefs.GetInt("Highscrore"))
        {
            PlayerPrefs.SetInt("Highscrore", playerData.count);
               
        }
        SceneManager.LoadScene("SampleScene");
    }
}
