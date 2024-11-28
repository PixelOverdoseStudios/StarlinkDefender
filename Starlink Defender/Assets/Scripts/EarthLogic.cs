using UnityEngine;

public class EarthLogic : MonoBehaviour
{
    private void OnCollisionEnter(Collision other)
    {
        if(other.gameObject.tag == "Asteroid")
        {
            Destroy(other.gameObject);
        }
    }
}
