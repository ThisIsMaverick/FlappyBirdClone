using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BirdScripts : MonoBehaviour
{
    public float jumping_range;
    Rigidbody2D rb;
    public Text score_text;
    public float score;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
        score = 0;
    }


    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            rb.velocity = Vector2.up * jumping_range;
        }

        score_text.text = score.ToString();
    }

    void OnTriggerEnter2D(Collider2D contact)
    {
        if(contact.gameObject.tag == "Scorer")
        {
            score++;
        }
    }

    private void OnCollisionEnter2D(Collision2D contact)
    {
        if(contact.gameObject.tag == "pipe")
        {
            Time.timeScale = 0;
        }
    }
}
