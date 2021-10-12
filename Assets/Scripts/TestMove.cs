using System;
using UnityEngine;

public class TestMove : MonoBehaviour
{
    [SerializeField] private Transform _testTarget;
    [SerializeField] [Range(0.0f, 15.0f)] private float _speed;
    
    private void Update()
    {
        transform.position = Vector3.MoveTowards(transform.position, _testTarget.position, 
            Time.deltaTime * _speed);
    }
}
