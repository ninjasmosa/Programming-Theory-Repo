using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sphere : Shape
{
    public override void Move()
    {
        moveSpeed = 100.0f;
        transform.Translate(Vector3.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }

    public override void Jump()
    {
        jumpStrength = 200.0f;
        playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
    }
}
