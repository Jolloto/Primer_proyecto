using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_Ejercicio : MonoBehaviour

{
   [SerializeField] private bool issaturday = true;


    void Start()
   {
    if (!issaturday)
    {
      Debug.Log("Es fin de semana");
    }
    else
    {
      Debug.Log("Es entre semana");
    }
   }

   
}