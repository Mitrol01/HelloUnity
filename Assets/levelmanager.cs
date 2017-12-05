using System.Collections;
using System.Collections.Generic;
using UnityEngine.SceneManagement;
using UnityEngine;

public class levelmanager : MonoBehaviour {
    // Use this for initialization
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Quit();
        }
        if (Input.GetKeyDown(KeyCode.KeypadEnter))
        {
            ChangeScene();
        }
        if (Input.GetKeyDown(KeyCode.P))
        {
            Pause();
        }
    }

    public void ChangeScene()
    {
        SceneManager.LoadScene(0);
    }
    public void Quit()
    {
        Application.Quit();
    }
    public void Pause()
    {
        if (Time.timeScale==0)
        {
            Time.timeScale = 1;

        }
        else
        {
            Time.timeScale = 0;

        }
    }
}
