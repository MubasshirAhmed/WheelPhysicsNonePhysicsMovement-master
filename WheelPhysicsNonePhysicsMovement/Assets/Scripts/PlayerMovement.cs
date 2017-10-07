using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    private float _horizontal;
    private float _vertical;
    private Vector3 _movement;
    float i = 0;
    public float speed = 15.0f;
    // Use this for initialization
    void Start()
    {

    }

    private void Update()
    {
        _horizontal = Input.GetAxis("Horizontal");
        transform.Rotate(0, _horizontal * 5f, 0, Space.World);
    }

    // Update is called once per frame
    void FixedUpdate()
    {
        //if (Mathf.Abs(transform.localEulerAngles.y) <= 135f && Mathf.Abs(transform.localEulerAngles.y) >= 45f)
        //{
        //    _movement = -(new Vector3(/*Input.GetAxis("Vertical")*/0, 0, Input.GetAxis("Vertical")));
        //}

        //if ((Mathf.Abs(transform.localEulerAngles.y) < 45f && Mathf.Abs(transform.localEulerAngles.y) >= 0f) || (Mathf.Abs(transform.localEulerAngles.y) <= 360f && Mathf.Abs(transform.localEulerAngles.y) >= 315f))
        //{
        //    _movement = new Vector3(Input.GetAxis("Vertical"), 0, 0/*Input.GetAxis("Vertical")*/);
        //}

        //if (Mathf.Abs(transform.localEulerAngles.y) < 315.0f && Mathf.Abs(transform.localEulerAngles.y) >= 225f)
        //{
        //    _movement = new Vector3(/*Input.GetAxis("Vertical")*/0, 0, Input.GetAxis("Vertical"));
        //}

        //if (Mathf.Abs(transform.localEulerAngles.y) < 225f && Mathf.Abs(transform.localEulerAngles.y) > 135)
        //{
        //    _movement = new Vector3(-Input.GetAxis("Vertical"), 0, 0);
        //}

        Debug.Log(Mathf.Abs(transform.eulerAngles.z));

        //if (Mathf.Abs(transform.localEulerAngles.z) <= 135f && Mathf.Abs(transform.localEulerAngles.z) >= 45f)
        //{
        //    GetComponent<Rigidbody>().AddForce(transform.right * 10.0f);
        //}

        //else if ((Mathf.Abs(transform.localEulerAngles.z) < 45f && Mathf.Abs(transform.localEulerAngles.z) >= 0f) || (Mathf.Abs(transform.localEulerAngles.z) <= 360f && Mathf.Abs(transform.localEulerAngles.z) >= 315f))
        //{
        //    GetComponent<Rigidbody>().AddForce(transform.right * 10.0f);
        //}

        //else if (Mathf.Abs(transform.localEulerAngles.z) < 315.0f && Mathf.Abs(transform.localEulerAngles.z) >= 225f)
        //{
        //    GetComponent<Rigidbody>().AddForce(transform.up * 10.0f);
        //}

        //else if (Mathf.Abs(transform.localEulerAngles.z) < 225f && Mathf.Abs(transform.localEulerAngles.z) > 135)
        //{
        //    GetComponent<Rigidbody>().AddForce(-transform.up * 10.0f);
        //}
        if (Input.GetKey(KeyCode.UpArrow))
        {
            if (Mathf.Abs(transform.eulerAngles.z) < 90f && Mathf.Abs(transform.eulerAngles.z) >= 0f)
            {
                //GetComponent<Rigidbody>().AddForce(-transform.right * speed);
                AddForceRight(-1);
            }

            else if (Mathf.Abs(transform.eulerAngles.z) < 180f && Mathf.Abs(transform.eulerAngles.z) >= 90f)
            {
                //GetComponent<Rigidbody>().AddForce(transform.up * speed);
                AddForceUp(1);
            }

            else if (Mathf.Abs(transform.eulerAngles.z) <= 270f && Mathf.Abs(transform.eulerAngles.z) >= 180f)
            {
                //GetComponent<Rigidbody>().AddForce(transform.right * speed);
                AddForceRight(1);
            }

            else if (Mathf.Abs(transform.eulerAngles.z) <= 360f && Mathf.Abs(transform.eulerAngles.z) >= 270f)
            {
                //GetComponent<Rigidbody>().AddForce(-transform.up * speed, ForceMode.Acceleration);
                AddForceUp(-1);
            }
        }

        //else if ((Mathf.Abs(transform.eulerAngles.z) < 45f && Mathf.Abs(transform.eulerAngles.z) >= 0f) || (Mathf.Abs(transform.eulerAngles.z) <= 360f && Mathf.Abs(transform.eulerAngles.z) >= 315f))
        //{
        //    GetComponent<Rigidbody>().AddForce(transform.right * 10.0f);
        //}

        //else if (Mathf.Abs(transform.eulerAngles.z) < 315.0f && Mathf.Abs(transform.eulerAngles.z) >= 225f)
        //{
        //    GetComponent<Rigidbody>().AddForce(transform.up * 10.0f);
        //}

        //else if (Mathf.Abs(transform.eulerAngles.z) < 225f && Mathf.Abs(transform.eulerAngles.z) > 135)
        //{
        //    GetComponent<Rigidbody>().AddForce(-transform.up * 10.0f);
        //}

        //_movement = new Vector3(Input.GetAxis("Vertical"), 0, Input.GetAxis("Vertical"));

        //GetComponent<Rigidbody>().AddForce(transform.right * 10.0f /** _movement * 2500 * Time.deltaTime*/);
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
