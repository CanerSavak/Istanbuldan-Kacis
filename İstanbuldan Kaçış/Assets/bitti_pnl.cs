using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class bitti_pnl : MonoBehaviour
{
    public void buton1()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/SampleScene");
    }
    public void buton3()
    {
        Application.Quit();
    }


}

