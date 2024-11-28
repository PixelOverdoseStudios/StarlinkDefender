using UnityEngine;

public class SatelliteInfo : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Asteroid")
        {
            Destroy(other.gameObject);
        }
    }
}
