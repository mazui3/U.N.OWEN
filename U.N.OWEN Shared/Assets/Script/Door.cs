using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Door : MonoBehaviour
{
    public int direction;
    public bool doorOpen = false;
    public GameObject mainDoor;

    public int closeTime = 0;
    public float speed = 0.01f;

    public GameObject DoorStuck;
    public GameObject DoorSound;
    
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (closeTime > 0)
        {
            closeTime += 1;

            if (closeTime == 60)
            {
                closeTime = 0;
            }
        }
    }

    private void OnTriggerStay2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            if (Input.GetButtonDown("Interact"))
            {
                if (doorOpen == false && closeTime == 0)
                {
                    Debug.Log("Open");
                    doorOpen = true;
                    mainDoor.SetActive(false);
                    DoorSound.GetComponent<AudioSource>().Play();
                    closeTime = 1;
                }

                if (doorOpen == true && DoorStuck.GetComponent<CheckDoorStuck>().stuckDoor == false && closeTime == 0)
                {
                    doorOpen = false;
                    mainDoor.SetActive(true);
                    DoorSound.GetComponent<AudioSource>().Play();
                    closeTime = 1;
                }
            }
        }
    }
}
