using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObstacleGenerator : MonoBehaviour
{
    [SerializeField] GameObject obstaclePrefab;
    [SerializeField] int obstacleSpawnRate = 1000;
    [SerializeField] float obstacleVerticalSpawnVariable = 0.5f;

    private const float DESPAWN_DELAY = 6f;

    private int timer;


    void FixedUpdate()
    {
        timer++;
        if(timer >= obstacleSpawnRate)
        {
            GameObject newObstacle = Instantiate(obstaclePrefab, new Vector2(obstaclePrefab.transform.position.x, obstaclePrefab.transform.position.y + Random.Range(-obstacleVerticalSpawnVariable, obstacleVerticalSpawnVariable)), obstaclePrefab.transform.rotation);
            Destroy(newObstacle, DESPAWN_DELAY);
            timer = 0;
        }
    }
}
