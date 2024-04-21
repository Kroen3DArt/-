using UnityEngine;

public class capsuleScale : MonoBehaviour
{
    [SerializeField] private Vector3 _endSize;
    [SerializeField] private float _scaleSpeed;

    private Vector3 _startSize;
    private Vector3 _targetScale;

    private bool _isScaled = false;

    private void Start()
    {
        _startSize = transform.localScale;
        _targetScale = _endSize;
    }

    void Update()
    {
        transform.localScale = Vector3.Lerp(transform.localScale, _targetScale, _scaleSpeed * Time.deltaTime);

        if ((transform.localScale - _targetScale).sqrMagnitude < 0.1f)
        {
            _isScaled = !_isScaled;

            if (_isScaled)
                _targetScale = _startSize;
            else
                _targetScale = _endSize;
        }
    }
}
