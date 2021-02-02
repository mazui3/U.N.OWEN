using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CheckGameProgress : MonoBehaviour
{
    public static int talkedPeople = 0;
    public GameObject[] others;
    public GameObject player;

    public GameObject EndGame;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        for (int i =0;i < others.Length; i++)
        {
            if (others[i].GetComponent<NPC>().talked == true && others[i].GetComponent<NPC>().counted == false)
            {
                talkedPeople += 1;
                others[i].GetComponent<NPC>().counted = true;
            }
        }

        Debug.Log(talkedPeople);
        EndGameScene();
    }

    void EndGameScene()
    {
        if (talkedPeople == 9)
        {
            EndGame.SetActive(true);
            PlayerMovement.playerLocked = true;
            player.GetComponent<HealthManager>().health = 10000;
        }
    }
}
