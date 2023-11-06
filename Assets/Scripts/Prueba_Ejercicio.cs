using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_Ejercicio : MonoBehaviour
{
    [SerializeField] private int grade = 7;

    void Start()
    {
    
     if (grade >= 9) 
     {
        Debug.Log("a");
     }
     else if (grade >= 7) 
     {
        Debug.Log("b");
     }
     else if (grade >= 5)
     {
        Debug.Log("c");
     }
     else  
     {
        Debug.Log("d");
     }
    
    }

   
}
