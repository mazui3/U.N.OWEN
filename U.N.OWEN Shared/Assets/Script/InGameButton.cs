using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class InGameButton : MonoBehaviour
{
    public void MainMenu()
    {
        SceneManager.LoadScene("MainMenu");
        AudioScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        AudioScript.SetInstance();
    }

    public void GameFinish()
    {
        SceneManager.LoadScene("Guess");
    }


}
