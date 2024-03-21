using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField, Range(0.01f, 10f)] private float _speed;

    void Update()
    {
        transform.localScale += Vector3.one * _speed * Time.deltaTime;
    }
}
