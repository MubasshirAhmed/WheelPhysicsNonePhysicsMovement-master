using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndRotate : MonoBehaviour
{

    private float _moveSpeed = 1000.0f;
    private float _moveRotationSpeed = 1000.0f;
    private float _rotationSpeed = 100.0f;
    private Rigidbody _rb;
    private float _horizontal;
    private GameObject go;

    // Use this for initialization
    void Start()
    {
        _rb = GetComponent<Rigidbody>();
        go = transform.Find("Capsule").gameObject;
    }

    // Update is called once per frame

    private void Update()
    {
        if (Input.GetKey(KeyCode.UpArrow))
            RotateWithoutPhysics();
        _horizontal = Input.GetAxis("Horizontal");
        RotateWithPhysics();
    }
    void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.UpArrow))
        {
            _rb.MovePosition(transform.position + transform.forward * Time.deltaTime * (_moveSpeed / 100));           
        }       
    }

    void RotateWithPhysics()
    {
        //Quaternion deltaRotation = Quaternion.Euler(Vector3.left * Time.deltaTime * (-_horizontal) * _rotationSpeed);
        //_rb.MoveRotation(_rb.rotation * deltaRotation);
        transform.Rotate(_horizontal *_rotationSpeed * Time.deltaTime, 0, 0);
    }

    void RotateWithoutPhysics()
    {        
        Quaternion deltaRotation = Quaternion.Euler(Vector3.down * _moveRotationSpeed * Time.deltaTime);
        go.transform.rotation *= deltaRotation;
        //go.transform.Rotate(0, _rotationSpeed * Time.deltaTime, 0) ;
    }
}
