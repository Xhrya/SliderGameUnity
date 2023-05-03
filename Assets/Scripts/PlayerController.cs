using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    Rigidbody2D _rb;
    [SerializeField] ObjectBehavior _objectBehavior;

    float _playerSpeed = 10f;
    float _inputHorizontal;

    // Start is called before the first frame update
    void Start()
    {

        _rb = gameObject.GetComponent<Rigidbody2D>();
        _objectBehavior.SpawnObject();

        
    }

    // Update is called once per frame
    void Update()
    {
        _inputHorizontal = Input.GetAxisRaw("Horizontal");
        if (_inputHorizontal != 0)
        {
                _rb.AddForce(new Vector2(_inputHorizontal * _playerSpeed, 0f ));
                //if i were to more 10 in speed and veloty is et to5
                //doing add for will make sure that when
                //could also use veloty depending ont he type
        }
    }
}
