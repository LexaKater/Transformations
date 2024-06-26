using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private Vector3 _movementDirection;

    private void Update()
    {
        transform.Translate(_movementDirection * Time.deltaTime);
        transform.LookAt( transform.position );
    }
}