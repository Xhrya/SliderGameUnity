using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Test : MonoBehaviour
{
    //c
    //here, I can wrap almost any game obje from the inspeor section

    
    Rigidbody2D _rb;
    float _walkSpeed;
    float _inputHorizontal;
    // Start is called before the first frame update
    void Start()
    {
      _rb = gameObject.GetComponent<Rigidbody2D>();
        _walkSpeed = 5.5f;
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal"); 
        //the number inside here will ange based on what I'm pressing here

        if(_inputHorizontal !=0)
        {
           _rb.AddForce(new Vector2(_inputHorizontal * _walkSpeed, 0f));
        }
    }
}
