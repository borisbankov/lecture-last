using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class MovementDirection : MonoBehaviour
{
    // Start is called before the first frame update
    public float speed = 20.0f;
    public bool isGrounded = true;
    public float jumpSpeed = 8.0f;
    public TextMeshProUGUI text;
    public float rotateSpeed = 5.0f;

    private Rigidbody _rb;
    private float _horizontalRotation;
    

    private void Start()
    {
        _rb = GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.anyKeyDown)
        {
            text.text = "Key " + Input.inputString + " pressed.";
        }

        if (Input.GetKeyDown(KeyCode.Space) && isGrounded)
        {
            _rb.AddForce(Vector3.up * jumpSpeed, ForceMode.Impulse);
        }

        if (Input.GetMouseButton(1))
        {
            _horizontalRotation = Input.GetAxis("Mouse X");
            transform.Rotate(_horizontalRotation * rotateSpeed * Vector3.up, Space.World);
        }
    }

    private void FixedUpdate()
    {
        if (Input.GetKey(KeyCode.W))
        {
            _rb.AddForce(speed * transform.forward);
        }
        if (Input.GetKey(KeyCode.S))
        {
            _rb.AddForce(speed * -transform.forward);
        }
        if (Input.GetKey(KeyCode.D))
        {
            _rb.AddForce(speed * transform.right);
        }
        if (Input.GetKey(KeyCode.A))
        {
            _rb.AddForce(speed * -transform.right);
        }

        if (Input.GetKey(KeyCode.X))
        {
            _rb.velocity = Vector3.zero;
        }

    }

    private void OnCollisionEnter(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = true;
    }

    private void OnCollisionExit(Collision collision)
    {
        if (collision.gameObject.CompareTag("Ground"))
            isGrounded = false;
    }
}
