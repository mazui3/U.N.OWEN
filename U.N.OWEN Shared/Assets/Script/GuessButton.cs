using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GuessButton : MonoBehaviour
{
    public void Win()
    {
        SceneManager.LoadScene("Win");
        AudioScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        AudioScript.SetInstance();
    }

    public void GameOver()
    {
        SceneManager.LoadScene("GameOver");
        AudioScript.Instance.gameObject.GetComponent<AudioSource>().Pause();
        AudioScript.SetInstance();
    }
}
