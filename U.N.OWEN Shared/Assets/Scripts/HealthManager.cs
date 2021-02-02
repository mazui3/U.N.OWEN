using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class HealthManager : MonoBehaviour
{
    public Image[] healthStack;
    public int health;

    private int delayDeduction = 0;

    public GameObject HeartBeat;

    public GameObject HealthPickup;

    public GameObject TakeDamage;

    public GameObject GameOver;

    public GameObject FadeScreen;

    public GameObject BackgroundMusic;

    // Start is called before the first frame update
    void Start()
    {
        health = 5;
    }

    // Update is called once per frame
    void Update()
    {
        if (delayDeduction > 0)
        {
            delayDeduction += 1;
            if (delayDeduction % 5 == 3) gameObject.GetComponent<SpriteRenderer>().enabled = false;
            else if (delayDeduction % 5 == 0) gameObject.GetComponent<SpriteRenderer>().enabled = true;
        }
        if (delayDeduction == 120)
        {
            delayDeduction = 0;
        }

        if (health <= 1)
        {
            if (!HeartBeat.GetComponent<AudioSource>().isPlaying)
            {
                HeartBeat.GetComponent<AudioSource>().Play();
            }
        }
        else HeartBeat.GetComponent<AudioSource>().Stop();

        if (health <= 0)
        {
            Death();
            Destroy(gameObject);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if ((collision.gameObject.CompareTag("MeleeEnemy") || collision.gameObject.CompareTag("RangeEnemy") || collision.gameObject.CompareTag("Bullet")) && delayDeduction == 0 && Vector2.Distance(collision.gameObject.transform.position, transform.position) < 1f)
        {
            health -= 1;
            health = Mathf.Max(health, 0);
            delayDeduction += 1;
            for (int i = 0; i < healthStack.Length; i++) healthStack[i].gameObject.SetActive(false);
            for (int i = 0; i < health; i++) healthStack[i].gameObject.SetActive(true);
            TakeDamage.GetComponent<AudioSource>().Play();
        }

        if (collision.gameObject.CompareTag("Health"))
        {
            health += 1;
            health = Mathf.Min(health, 5);
            for (int i = 0; i < healthStack.Length; i++) healthStack[i].gameObject.SetActive(false);
            for (int i = 0; i < health; i++) healthStack[i].gameObject.SetActive(true);
            HealthPickup.GetComponent<AudioSource>().Play();
            Destroy(collision.gameObject);
        }
    }

    void Death()
    {
        /*GameOver.GetComponent<AudioSource>().Play();
        BackgroundMusic.GetComponent<AudioSource>().Stop();
        gameObject.GetComponent<AudioSource>().Stop();
        FadeScreen.SetActive(true);*/
        SceneManager.LoadScene(2);
    }
}
