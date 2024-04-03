using UnityEngine;

public class Rotator : MonoBehaviour
{
    [SerializeField] private int _speedRotate;

    private void Update()
    {
        Rotate();
    }

    private void Rotate() 
    {
        transform.Rotate(0, _speedRotate, 0, Space.Self);
    }
}
