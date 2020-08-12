using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class thirdPerson : MonoBehaviour
{
    private Rigidbody body;
    private Transform player;
    public Transform head;
    public float speed;
    private bool isGrounded;
    public Transform groundCheck;
    public float soleThickness;
    private Vector3 moveDir;

    private void Start()
    {
        body = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        float z = Input.GetAxis("Vertical");
        //body.AddForce(-transform.up* 1000f);
        body.velocity = Vector3.down * 100f;
        Debug.Log(transform.InverseTransformDirection(body.velocity));
        Debug.Log(transform.up);
    }
}
