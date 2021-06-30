using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MenuManage : MonoBehaviour
{

    public void startButton()
    {
        Time.timeScale = 1.0f;
        SceneManager.LoadScene("Scenes/SampleScene");
    }
    public void quit()
    {
        Application.Quit();
    }
}

