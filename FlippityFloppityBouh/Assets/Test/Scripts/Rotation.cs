using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Rotation : MonoBehaviour
{
    [SerializeField] private GameObject _gameObject;

    private void Update()
    {
        RotationGameObject();
    }

    private void RotationGameObject()
    {
        _gameObject.transform.Rotate(,);
    }
}
