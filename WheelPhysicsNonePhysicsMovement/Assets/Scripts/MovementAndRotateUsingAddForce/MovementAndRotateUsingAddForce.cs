using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovementAndRotateUsingAddForce : MonoBehaviour
{

    private float _horizontal;
    public float speed = 15.0f;

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, _horizontal * 5f, 0, Space.World);
    }

    // Update is called once per frame
    void FixedUpdate()
    {

        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Mathf.Abs(transform.eulerAngles.z) < 90f && Mathf.Abs(transform.eulerAngles.z) >= 0f)
                AddForceRight(-1);
            else if (Mathf.Abs(transform.eulerAngles.z) < 180f && Mathf.Abs(transform.eulerAngles.z) >= 90f)
                AddForceUp(1);
            else if (Mathf.Abs(transform.eulerAngles.z) <= 270f && Mathf.Abs(transform.eulerAngles.z) >= 180f)
                AddForceRight(1);
            else if (Mathf.Abs(transform.eulerAngles.z) <= 360f && Mathf.Abs(transform.eulerAngles.z) >= 270f)
                AddForceUp(-1);
        }
    }

    private void AddForceRight(int sign)
    {
        GetComponent<Rigidbody>().AddForce((transform.right * sign) * speed);
    }

    private void AddForceUp(int sign)
    {
        GetComponent<Rigidbody>().AddForce((transform.up * sign) * speed);
    }
}
