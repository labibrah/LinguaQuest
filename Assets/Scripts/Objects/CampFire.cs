using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CampFire : Interactable
{

    public SpriteRenderer campfireSprite; // Reference to the campfire sprite renderer
    public Animator campfireAnimator; // Reference to the campfire animator
    public Transform respawnPoint; // The point where the player will respawn
    public FloatValue playerHealth; // Reference to the player's health
    public Signal playerHealthSignal; // Signal to notify when the player's health is reset

    void Awake()
    {
        if (campfireSprite == null)
        {
            campfireSprite = GetComponent<SpriteRenderer>();
        }
        if (campfireAnimator == null)
        {
            campfireAnimator = GetComponent<Animator>();
        }
    }

    void Update()
    {
        if (playerInRange && Input.GetKeyDown(KeyCode.E))
        {
            ActivateCampfire();
        }
    }

    private void ActivateCampfire()
    {
        Debug.Log("Campfire activated!");
        audioSource.PlayOneShot(interactSound); // Play interaction sound
        campfireAnimator.SetBool("activated", true); // Set the animator parameter to indicate the campfire is lit
        PlayerRespawnManager.Instance.SetRespawnPoint(respawnPoint.position);
        playerHealth.runtimeValue = playerHealth.initialValue; // Reset player health
        playerHealthSignal.Raise(); // Notify that the player's health has been reset


    }
}
