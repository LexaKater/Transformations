using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField, Range(1f, 1000f)] private float _speed;

    private void Update()
    {
        transform.RotateAround(transform.position, Vector3.up, _speed * Time.deltaTime);
    }
}
