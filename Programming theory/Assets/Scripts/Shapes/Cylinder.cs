using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cylinder : Shape
{
    public override void Move() // INHERITANCE
    {
        // POLYMORPHISM
        moveSpeed = 25.0f;
        transform.Translate(Vector3.forward * moveSpeed * Input.GetAxis("Vertical") * Time.deltaTime);
        transform.Translate(Vector3.right * moveSpeed * Input.GetAxis("Horizontal") * Time.deltaTime);
    }

    public override void Jump() // INHERITANCE
    {
        // POLYMORPHISM
        jumpStrength = 100.0f;
        playerRb.AddForce(Vector3.up * jumpStrength, ForceMode.Impulse);
    }
}
