// using System.Collections;
// using System.Collections.Generic;
// using UnityEngine;

// public class Test3 : MonoBehaviour

// private int _playerHealth = 100;
// private int _playerSheild = 50;

// {
//     // Start is called before the first frame update
//     void Start()
//     {
//         Debug.Log("You took: " + DamageTaken(80) + "in damage!");   
//     }

//     // Update is called once per frame
//     void Update()
//     {
        
//     }

//     int DamageTaken(int damage)
//     {
//         //method inside a method is alled a funion

//         int damageTaken; //start with small starting 
//         if(damage < _playerSheild)
//         {
//             Debug.Log("Sheild not destroyed");
//         }
//         else if(damange == _playerSheild)
//         {
//             Debug.Log("Sheild destroyed");
//             damageTaken=0;
//         }
    
//         else
//         {
//             Debug.Log("Shield destroyed!");
//             damageTaken= damage - _playerSheild;
//         }


//         return damageTaken;


//     }
// }
