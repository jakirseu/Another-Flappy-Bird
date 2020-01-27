using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlyBird : MonoBehaviour
{
    public GameManager gameManager;

    float velocity = 3;
    Rigidbody2D rb;

    void Start()
    {
        rb = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {

            rb.velocity = Vector2.up * velocity;

            SoundManager.PlaySound("fly");

        }
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        Time.timeScale = 0;
        SoundManager.PlaySound("hit");

        gameManager.GameOver();

    }
}
