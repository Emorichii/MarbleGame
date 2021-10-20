using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[RequireComponent(typeof(Rigidbody))]
public class PlayerMovement : MonoBehaviour
{
    [Tooltip("Speed multiplier for horizontal and Vertical movement.")]
    [Range(5,50)]  //adds a slider to drag
    public float speed = 10;
    public float jumpPower = 10;
    Rigidbody rb;

    void Start()
    {
        rb = this.GetComponent<Rigidbody>();
    }

    // CREATE A FUNCTION TO MOVE
    public void MoveHorizontal(float force)
    {
        rb.AddForce(force * speed, 0, 0);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping");
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    public void MoveVertical(float force)
    {
        rb.AddForce(0, 0, force * speed);
        if(Input.GetKeyDown(KeyCode.Space))
        {
            Debug.Log("Jumping");
            rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
        }
    }
    // public void Jump()
    // {
    //     if(Input.GetKeyDown(KeyCode.Space))
    //     {
    //         Debug.Log("Jumping");
    //         rb.AddForce(Vector3.up * jumpPower, ForceMode.Impulse);
    //     }
    //     else
    //     {
    //         Debug.Log("Not today");
    //     }
    // }
}
