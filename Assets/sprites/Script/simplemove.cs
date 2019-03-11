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
        float So = transform.position.x;
        float S = So + SpeedFactor * HorizontalInput * Time.deltaTime;
        
      transform.position = new Vector3 (S, transform.position.y, transform.position.z);
    }
}
