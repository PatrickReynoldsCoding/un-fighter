using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DieOffScreen : MonoBehaviour
{

    private bool isOffScreen;
    public float allowedTimeOffscreen;

        IEnumerator KillAfterNSeconds(float seconds)
    {
        // Wait for the specified number of seconds
        yield return new WaitForSeconds(seconds);

        Destroy(gameObject);
    }


    void Update()
    {
        // Convert the game object's position to screen space
        Vector2 screenPos = Camera.main.WorldToScreenPoint(transform.position);

        // Check if the game object is offscreen
        if (screenPos.x < 0 || screenPos.x > Screen.width || screenPos.y < 0 || screenPos.y > Screen.height)
        {
            // Destroy the game object
            isOffScreen = true;
        }
      
        if (isOffScreen)
        {
            StartCoroutine(KillAfterNSeconds(allowedTimeOffscreen));
        }
    }
}
