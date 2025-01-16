using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControllerX : MonoBehaviour
{
    public GameObject dogPrefab;
    private float lastSpawnTime;
    private float spawnCooldown = 1.0f; // Tiempo en segundos entre cada spawn

    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            // Verifica si ha pasado suficiente tiempo desde el último spawn
            if (Time.time - lastSpawnTime >= spawnCooldown)
            {
                // Instancia el prefab de perro
                Instantiate(dogPrefab, transform.position, dogPrefab.transform.rotation);

                // Actualiza el tiempo del último spawn
                lastSpawnTime = Time.time;
            }
        }
    }
}
