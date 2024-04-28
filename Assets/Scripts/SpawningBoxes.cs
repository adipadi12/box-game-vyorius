using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawningBoxes : MonoBehaviour
{
    public GameObject prefabToSpawn; // The prefab to spawn
    public Transform spawnPosition; // The position to spawn the prefab

    // Update is called once per frame
    void Update()
    {
        // Check if the user pressed the spacebar
        
            // Spawn the prefab at the specified position
        Instantiate(prefabToSpawn, spawnPosition.position, Quaternion.identity);
        
    }
}

