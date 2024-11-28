using UnityEngine;

public class AsteroidLogic : MonoBehaviour
{
    [SerializeField] float speed = 2f;

    Transform targetPosition;

    private void Start()
    {
        targetPosition = GameObject.FindFirstObjectByType<EarthSpinScript>().transform;
    }

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, targetPosition.position, speed * Time.deltaTime);
    }
}
