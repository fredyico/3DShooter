using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
public void StartGame()
    {
        SceneManager.LoadScene("StartGameScreen");
    }

    public void StageOne()
    {
        SceneManager.LoadScene("Stage1");
    }

    public void StageTwo()
    {
        SceneManager.LoadScene("Stage2");
    }



    // Update is called once per frame
    void Update()
    {
        Cursor.visible = true;
        Cursor.lockState = CursorLockMode.None;
    }
}
