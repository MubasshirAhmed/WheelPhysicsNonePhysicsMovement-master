using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndRotatePhysics : MonoBehaviour
{
    private Rigidbody _rb;
    private float _horizontal;
    private float _movementRotationSpeed = 3500.0f;
    private float _rotationSpeed = 500.0f;

    // Use this for initialization
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        _rb.maxAngularVelocity = 28.0f;
    }

    // Update is called once per frame
    private void Update()
    {
        //_horizontal = Input.GetAxis("Horizontal");
        //positionController.transform.Rotate(0, _horizontal * _rotationSpeed * Time.deltaTime, 0, Space.World);
    }

    void FixedUpdate()
    {
        _horizontal = Input.GetAxis("Horizontal");
        _rb.AddTorque(Vector3.up * _horizontal * Time.fixedDeltaTime * _rotationSpeed);
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.AddTorque(transform.up * _movementRotationSpeed * Time.fixedDeltaTime);
        }
        else if (Input.GetKey(KeyCode.DownArrow))
        {
            _rb.AddTorque(-transform.up * _movementRotationSpeed * Time.fixedDeltaTime);
        }
    }
}
