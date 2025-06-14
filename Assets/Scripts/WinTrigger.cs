using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

/// <summary>
/// WinTrigger is a specialized MonoBehaviour that handles the win condition logic in the game.
/// It manages the transition from gameplay to victory state, including UI updates and audio changes.
/// This component should be attached to a trigger collider at the end of each level.
/// </summary>
public class WinTrigger : MonoBehaviour
{
    [Tooltip("Reference to the player GameObject that will trigger the win condition")]
    public GameObject player;

    [Tooltip("UI Text component displaying the timer that will be stopped on win")]
    public Text timerText;

    [Tooltip("Canvas containing victory UI elements that will be shown on win")]
    public GameObject winCanvas;

    [Tooltip("Audio source for the main gameplay background music")]
    public AudioSource cheeryMondayBGM;

    [Tooltip("Audio source for the victory celebration music")]
    public AudioSource victoryPianoBGM;

    /// <summary>
    /// Initializes the component by finding the player and ensuring the victory music is stopped.
    /// This is called when the script instance is being loaded.
    /// </summary>
    void Start()
    {
        // Find the player in the scene using the PlayerController component
        player = FindObjectOfType<PlayerController>().gameObject;
        // Ensure victory music is not playing at start
        victoryPianoBGM.Stop();
    }

    /// <summary>
    /// Handles the win condition when the player enters the trigger zone.
    /// This method is called automatically by Unity when a collider enters this trigger.
    /// </summary>
    /// <param name="other">The collider that entered the trigger zone</param>
    void OnTriggerEnter(Collider other)
    {
        // Disable the timer component to stop the countdown
        player.GetComponent<Timer>().enabled = false;

        // Show the victory UI canvas
        winCanvas.SetActive(true);

        // Disable the pause menu to prevent player from pausing during victory
        player.GetComponent<PauseMenu>().enabled = false;

        // Call the Win method on the Timer component to handle victory logic
        player.GetComponent<Timer>().Win();

        // Stop the main gameplay music
        cheeryMondayBGM.Stop();

        // Play the victory celebration music
        victoryPianoBGM.Play();

        // Freeze the game time to create a pause effect
        Time.timeScale = 0;
    }
}
