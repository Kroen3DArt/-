using UnityEngine;

public class Scale : MonoBehaviour
{
    [SerializeField] private Vector3 _targetScale;
    [SerializeField] private float _scaleSpeed;

    private void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _targetScale, _scaleSpeed * Time.deltaTime);
    }
}
