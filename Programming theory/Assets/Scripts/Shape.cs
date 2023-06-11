using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class Shape : MonoBehaviour
{
    protected float jumpStrength;
    protected float moveSpeed;
    public Rigidbody playerRb;

    private void Start()
    {
        playerRb = GetComponent<Rigidbody>();
    }

    private void Update()
    {
        Move();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            Jump();
        }
    }

    public virtual void Move()
    {
        moveSpeed = 50.0f;
        transform.Translate(Vector3.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }

    public virtual void Jump()
    {
        jumpStrength = 150.0f;
        playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
    }
}
