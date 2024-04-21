using UnityEngine;

public class cubeRotate : MonoBehaviour
{
    [SerializeField] private float _speedRotate;

    void Update()
    {
        transform.Rotate(Vector3.up * _speedRotate * Time.deltaTime);
    }
}
