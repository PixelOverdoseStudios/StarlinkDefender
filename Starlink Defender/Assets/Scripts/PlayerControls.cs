using UnityEngine;
using UnityEngine.InputSystem;

public class PlayerControls : MonoBehaviour
{
    [SerializeField] float rotationSpeed;
    [SerializeField] InputAction rotationControls;

    private void OnEnable()
    {
        rotationControls.Enable();
    }

    private void Start()
    {
        //particleTrail.Play();
    }

    void FixedUpdate()
    {
        float rotationValue = rotationControls.ReadValue<float>();
        if(rotationValue < 0)
        {
            transform.Rotate(0, 0, 1 * -rotationSpeed);
        }
        else if(rotationValue > 0)
        {
            transform.Rotate(0, 0, 1 * rotationSpeed);
        }
    }
}
