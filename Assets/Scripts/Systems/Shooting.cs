using System.Collections;
using System.Collections.Generic;
using UnityEngine;

using UnityEngine.InputSystem;


public class Shooting : MonoBehaviour
{



    public int shootIntervalFrames = 30;
    private int frameCounter = 0;

    public bool autoShoot;
    public Transform shootingPoint;
    public GameObject bulletPrefab;



    // Update is called once per frame
    void Update()
    {
        frameCounter++;

        if (Keyboard.current.spaceKey.wasPressedThisFrame || autoShoot && (frameCounter % shootIntervalFrames == 0))
        {
            Instantiate(bulletPrefab, shootingPoint.position, transform.rotation);
        }
        
    }
}
