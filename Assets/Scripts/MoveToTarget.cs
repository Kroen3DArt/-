using UnityEngine;

public class MoveToTarget : MonoBehaviour
{
    [SerializeField] private UnityEngine.Transform _target;
    [SerializeField] private float _speed;

    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _target.position, _speed * Time.deltaTime);
    }
}
