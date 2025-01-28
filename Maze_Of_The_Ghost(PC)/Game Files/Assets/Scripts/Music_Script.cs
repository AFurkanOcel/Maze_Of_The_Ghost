using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Music_Script : MonoBehaviour
{
    public AudioSource backgroundMusic; // Assign the AudioSource in the Inspector.

    private static Music_Script instance;

    void Awake()
    {
        // Singleton pattern to ensure only one MusicManager exists.
        if (instance == null)
        {
            instance = this;
            DontDestroyOnLoad(gameObject); // Prevent this object from being destroyed on scene changes.
        }
        else
        {
            Destroy(gameObject); // Destroy duplicate MusicManagers if one already exists.
        }
    }

    void Start()
    {
        if (!backgroundMusic.isPlaying)
        {
            backgroundMusic.loop = true; // Ensure the music loops.
            backgroundMusic.Play();
        }
    }
}
