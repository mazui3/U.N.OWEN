using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Story : MonoBehaviour
{
    public int indexDialogue;
    public int lengthDialogue;

    public void StoryAppear()
    {
        Dialogue.index = indexDialogue;
        Dialogue.index_start = indexDialogue;
        Dialogue.conversationLength = lengthDialogue;
    }

}
