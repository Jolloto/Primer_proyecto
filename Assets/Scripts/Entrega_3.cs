using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_3 : MonoBehaviour
{
   [SerializeField] private float num1;
   [SerializeField] private float num2;

   [SerializeField] private bool a = false;
   [SerializeField] private bool e = false;
   [SerializeField] private bool i = false;
   [SerializeField] private bool o = false;
   [SerializeField] private bool u = false;

   [SerializeField] private float num1;
   [SerializeField] private float num2; 


    void Start()
    {
        Debug.Log(num1 > num2);

       if (a) 
       {
            Debug.Log("Es vocal");
       }
       else if (e)
       {
            Debug.Log("Es vocal");
       }
       else if (i)
       {
            Debug.Log("Es vocal");
       }
       else if (o)
       {
            Debug.Log("Es vocal");
       }
       else if (u)
       {
            Debug.Log("Es vocal");
       }
       else 
       {
            Debug.Log("Es consonante");
       }

       
       void Calculator(int num1, int num2)
       {
            Debug.Log($"{num1} / {num2} = {num1 / num2}");
       }
    
    }

    
}
