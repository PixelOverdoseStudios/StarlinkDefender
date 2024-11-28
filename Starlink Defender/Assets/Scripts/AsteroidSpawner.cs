using UnityEngine;

public class AsteroidSpawner : MonoBehaviour
{
    [SerializeField] GameObject asteroid;
    [SerializeField] float spawnTime;
    private float spawnTimeCounter = 0;

    private void Update()
    {
        spawnTimeCounter += Time.deltaTime;

        if(spawnTimeCounter >= spawnTime)
        {
            int sideNum;
            sideNum = Random.Range(1, 5);

            switch(sideNum)
            {
                case 1:
                    SpawnAsteroidAtTop();
                    break;
                case 2:
                    SpawnAsteroidAtRight();
                    break;
                case 3:
                    SpawnAsteroidAtLeft();
                    break;
                case 4:
                    SpawnAsteroidAtBottom();
                    break;
            }

            RestartSpawnCounter();
        }
    }

    private void RestartSpawnCounter()
    {
        spawnTimeCounter = 0;
    }

    private void SpawnAsteroidAtTop()
    {
        float randomXValue;
        randomXValue = Random.Range(-10f, 10f);
        Instantiate(asteroid, new Vector3(randomXValue, 7f, 0f), Quaternion.identity);
    }

    private void SpawnAsteroidAtBottom()
    {
        float randomXValue;
        randomXValue = Random.Range(-10f, 10f);
        Instantiate(asteroid, new Vector3(randomXValue, -7f, 0f), Quaternion.identity);
    }

    private void SpawnAsteroidAtRight()
    {
        float randomYValue;
        randomYValue = Random.Range(-7f, 7f);
        Instantiate(asteroid, new Vector3(11f, randomYValue, 0f), Quaternion.identity);
    }

    private void SpawnAsteroidAtLeft()
    {
        float randomYValue;
        randomYValue = Random.Range(-7f, 7f);
        Instantiate(asteroid, new Vector3(-11f, randomYValue, 0f), Quaternion.identity);
    }
}
