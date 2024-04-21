using UnityEngine;

public class MoveTorwards : MonoBehaviour
{
    [SerializeField] private float _speedMove;

    private void Update()
    {
        Vector3 forwardDirection = transform.forward;
        Vector3 newPosition = transform.position + forwardDirection * _speedMove * Time.deltaTime;
        transform.position = newPosition;
    }
}
