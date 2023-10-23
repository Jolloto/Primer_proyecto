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

   [SerializeField] private int grade = 9;

   [SerializeField] private int mynumber;
   [SerializeField] private int mynumber2;

   [SerializeField] private bool issaturday = true;
 

    void Start()
    {
       if (num1 > num2) 
       {
          Debug.Log($"{num1} es mas grande");
       }
       else if (num2 > num1)
       {
          Debug.Log($"{num2} es mas grande");
       }

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

       if (grade >= 9) 
      {
         Debug.Log("A");
      }
       else if (grade >= 7) 
      {
         Debug.Log("B");
      }
      else if (grade >= 5)
      {
         Debug.Log("C");
      }
       else if (grade <= 4)
      {
         Debug.Log("D");
      }


     Debug.Log($"Es el {mynumber} divisble: {IsEven(mynumber2)}");

     }

     private bool IsEven(int number) 
     {
          if (mynumber % 2 == mynumber2) 
          {
               return true;
          }
          else
          {
               return false;
          }
     }

     
  

    
}

    

