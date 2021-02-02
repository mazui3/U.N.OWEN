using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class MainMenu : MonoBehaviour
{
    public int indexDialogue;
    public int lengthDialogue;
    public void PlayGame()
    {
        SceneManager.LoadScene("SampleScene");
    }
    public void Story()
    {
        Dialogue.index = indexDialogue;
        Dialogue.index_start = indexDialogue;
        Dialogue.conversationLength = lengthDialogue;
    
    }
    public void QuitGame()
    {
        Application.Quit();
    }
}
