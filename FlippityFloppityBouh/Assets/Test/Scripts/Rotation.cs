using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;
    [SerializeField] private float _rotationSpeed;

    private void Update()
    {
        RotationGameObject();
    }

    private void RotationGameObject()
    {
        _gameObject.transform.Rotate(new Vector3 (0,1,0), 1.0f * _rotationSpeed * Time.deltaTime);
    }
}
