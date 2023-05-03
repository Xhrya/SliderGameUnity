// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Test2 : MonoBehaviour
// {
//     //updating data variables prai

//     [SerializeField] private Rigidbody2D _rb;
    

    
//     private int _playerHealth = 100;  //public integer container. and it starts with lower
//    //case variable beause of ntention

    

//     private float _playerSpeed = 4.6f;
//     private bool _isGrounded = true;
//     private string _playerName = "Krossing";
//     private Vector3 _playerPosition = new Vector3(-50f, 0f, 0f);


//    //vs when we do private it has to start with _; vs public will be with upperase
//     //default state is private so generally starts with _, if there isn't a declaration in front


//     public int PublicHealth
//     {
//         get{
//             return _playerHealth;
//         }
//         set{
//             _playerHealth = value;
//         }
//     }

//     public int DisplayHealthPercentage
//     {
//         get{
//             string health = _playerHealth.ToString() + "%";
//             return _playerHealth;
//         }
//     }

//     public void Start()
//     {
//         gameObject.transform.position = _playerPosition;
//         _rb = gameObject.GetComponent<Rigidbody2D>();
//         _rb.gravityScale = 0; //

//         Debug.log("Daniel");

//         TakeDamage(50);
//         Debug.Log(PlayerHealth);

//     }

//     void TakeDamage()
//     {
//         PlayerHealth -= 10;
//     }

   


// }
