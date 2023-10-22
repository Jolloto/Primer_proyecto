using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_Ejercicio : MonoBehaviour
{
    [SerializeField] private int grade = a;

    void Start()
    {
    
     if (grade >= a) 
     {
        Debug.Log("Excelente");
     }
     else if (grade >= b) 
     {
        Debug.Log("Notable");
     }
     else if (grade >= c)
     {
        Debug.Log("Aprovado");
     }
     else if (grade >= d)
     {
        Debug.Log("Suspenso");
     }
    
    }

   
}
