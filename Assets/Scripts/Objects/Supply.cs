using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Supply : MonoBehaviour
{
    public FloatValue playerHealth; // Reference to the player's health
    public float healthAmount; // Amount of health to restore
    public Signal supplySignal; // Signal to notify when the supply is collected
    public AudioSource audioSource; // Audio source for playing sounds
    public AudioClip collectSound; // Sound to play when the supply is collected

    // Start is called before the first frame update
    void Start()
    {
        audioSource = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {

    }


}
