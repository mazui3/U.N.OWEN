using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Radio : MonoBehaviour
{
    public GameObject NameTag;
    private bool play = false;

    public GameObject RadioSound;
    private int delay = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (delay > 0) delay++;
        if (delay >= 70) delay = 0;
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            NameTag.SetActive(true);

            if (Input.GetKeyDown(KeyCode.E))
            {
                if (play == false && delay == 0)
                {
                    RadioSound.GetComponent<AudioSource>().Play();
                    NameTag.GetComponent<TextMesh>().text = "Stop";
                    play = true;
                    delay = 1;
                }
                else if (play == true && delay == 0)
                {
                    RadioSound.GetComponent<AudioSource>().Stop();
                    NameTag.GetComponent<TextMesh>().text = "Play";
                    play = false;
                    delay = 1;
                }
            }
        }
    }

    private void OnTriggerExit2D(Collider2D collision)
    {
        NameTag.SetActive(false);
    }
}
