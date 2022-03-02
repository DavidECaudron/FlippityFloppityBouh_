using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Thruster : MonoBehaviour
{
    [SerializeField] private float _impulseStrength;

    private GameObject _target;
    private Rigidbody _targetRigidBody;

    private void Update()
    {
        if (_target != null && Input.GetKey(KeyCode.Space))
        {
            _target.transform.rotation = Quaternion.identity;
        }
        if (_targetRigidBody != null && Input.GetKeyUp(KeyCode.Space))
        {
            _targetRigidBody.AddForce(new Vector3(0, 1, 0) * _impulseStrength, ForceMode.Impulse);
        }
    }

    private void OnTriggerEnter(Collider other)
    {
        _target = other.gameObject;
        _targetRigidBody = _target.GetComponent<Rigidbody>();
    }

    private void OnTriggerExit(Collider other)
    {
        _target = null;
        _targetRigidBody = null;
    }
}