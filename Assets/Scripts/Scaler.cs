using UnityEngine;

public class Scaler : MonoBehaviour
{
    [SerializeField] private int _speedRaise;
    [SerializeField] private int _maxScale;

    private void Update()
    {
        Increase();
    }

    private void Increase() 
    {
        if (transform.localScale.y <= _maxScale && transform.localScale.x <= _maxScale && transform.localScale.z <= _maxScale)
            transform.localScale *= _speedRaise + Time.deltaTime;
    }
}
