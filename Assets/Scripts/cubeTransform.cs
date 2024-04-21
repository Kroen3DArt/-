using UnityEngine;

public class cubeTransform : MonoBehaviour
{
    [SerializeField] private float _speedMove;
    [SerializeField] private float _rotateSpeed;
    [SerializeField] private float _scaleSpeed;
    [SerializeField] private Vector3 _endScale;

    private Vector3 _startScale;
    private Vector3 _targetScale;

    private bool _isScaled = false;

    private void Start()
    {
        _startScale = transform.localScale;
        _targetScale = _endScale;
    }

    private void Update()
    {
        Vector3 forwardDirection = transform.forward;
        Vector3 newPosition = transform.position + forwardDirection * _speedMove * Time.deltaTime;
        transform.position = newPosition;

        transform.Rotate(Vector3.up * _rotateSpeed * Time.deltaTime);

        transform.localScale = Vector3.Lerp(transform.localScale, _targetScale, _scaleSpeed * Time.deltaTime);

        if ((transform.localScale - _targetScale).sqrMagnitude < 0.1f)
        {
            _isScaled = !_isScaled;

            if (_isScaled)
                _targetScale = _startScale;
            else
                _targetScale = _endScale;
        }
    }
}
