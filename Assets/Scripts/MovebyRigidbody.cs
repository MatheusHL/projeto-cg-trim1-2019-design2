using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MovebyRigidbody : MonoBehaviour
{
[SerializeField]   
private float SpeedFactor = 10f;

 
private Rigidbody2D RB;

    void Start()
    {
        RB = GetComponent <Rigidbody2D>();
    }

    
    void Update()
    {
       float horizontalInput = Input.GetAxisRaw("Horizontal");
       float VerticalInput = Input.GetAxisRaw("Vertical");
       RB.velocity = new Vector3(horizontalInput, VerticalInput, 0f) * SpeedFactor;
 
    }
}
