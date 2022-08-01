using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObsticleGenerator : MonoBehaviour
{
    public GameObject pipePrefab;
    // How fast to generate new pipes.
    public int generationRate = 100;
    // Track elapsed time.
    private int timer;

    // Update is called at a fixed time.
    void FixedUpdate()
    {
        timer++;
        // Check if timer is greater than generationRate
        if (timer >= generationRate)
        {
            timer = 0; // Reset timer
            GameObject newObsticle = Instantiate(pipePrefab, new Vector2(pipePrefab.transform.position.x, pipePrefab.transform.position.y + Random.Range(-2f, 2f)), pipePrefab.transform.rotation);
            Destroy(newObsticle,5f); // Destoy obsticle after 5 seconds.
        } 

    }
}
