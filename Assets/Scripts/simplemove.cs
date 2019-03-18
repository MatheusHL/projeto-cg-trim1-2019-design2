using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class simplemove : MonoBehaviour
{
    [SerializeField]
    private float SpeedFactor = 1f;

    void Start()
    {
       
    }


    void Update()
    {
        float HorizontalInput = Input.GetAxisRaw("Horizontal");
        float VerticalInput = Input.GetAxisRaw("Vertical");

        Vector3 velocity = new Vector3(HorizontalInput, VerticalInput, 0f) * SpeedFactor;

        
      transform.position = transform.position + velocity * Time.deltaTime; 
    }
}
