using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManager : MonoBehaviour
{
    public static AudioClip playerHitSound, playerFlying, addScore;
    static AudioSource audioSource;


    void Start()
    {
        playerHitSound = Resources.Load<AudioClip>("hit");
        playerFlying = Resources.Load<AudioClip>("fly");
        addScore = Resources.Load<AudioClip>("score");

        audioSource = GetComponent<AudioSource>();

    }


    void Update()
    {

    }

    public static void PlaySound(string clip)
    {

        switch (clip)
        {
            case "hit":
                audioSource.PlayOneShot(playerHitSound);
                break;

            case "fly":
                audioSource.PlayOneShot(playerFlying);
                break;
            case "score":
                audioSource.PlayOneShot(addScore);
                break;



        }
    }
}
