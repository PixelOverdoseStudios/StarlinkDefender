using UnityEngine;

public class SatSpawnLogic : MonoBehaviour
{
    [SerializeField] Transform spawnPoint;
    [SerializeField] Transform endPoint;

    private void Update()
    {
        if(Input.GetKeyDown(KeyCode.T))
        {
            SpawningSatellite();
        }
        if(transform.position != endPoint.position)
        {
            transform.position = Vector3.MoveTowards(transform.position, endPoint.position, 5f * Time.deltaTime);
        }
    }

    private void SpawningSatellite()
    {
        transform.position = spawnPoint.position;       
    }

    private void MoveSat()
    {
        transform.position = Vector3.MoveTowards(transform.position, endPoint.position, 5f * Time.deltaTime);
    }
}
