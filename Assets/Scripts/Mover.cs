using UnityEngine;

public class Mover : MonoBehaviour
{
    [SerializeField] private int _speedMove;

    private void Update()
    {
        MoveForward();
    }

    private void MoveForward()
    {
        transform.Translate(Vector3.forward * _speedMove * Time.deltaTime);
    }
}
