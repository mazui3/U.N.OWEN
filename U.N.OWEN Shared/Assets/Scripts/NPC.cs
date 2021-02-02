using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NPC : MonoBehaviour
{
    public GameObject NameTag;
    public int indexDialogue;
    public int lengthDialogue;
    public GameObject chess_piece;
    public bool talked = false;
    public bool counted = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Dialogue.index == Dialogue.index_start + Dialogue.conversationLength - 1 && chess_piece.activeSelf == false) talked = true;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            NameTag.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E) && talked == false)
            {
                Dialogue.index = indexDialogue;
                Dialogue.index_start = indexDialogue;
                Dialogue.conversationLength = lengthDialogue;
                PlayerMovement.playerLocked = true;
                chess_piece.SetActive(false);
                //talked = true;
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NameTag.SetActive(false);
    }
}
