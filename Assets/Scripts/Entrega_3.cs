using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Entrega_3 : MonoBehaviour
{
   [SerializeField] private float num1;
   [SerializeField] private float num2;
    /*
       [SerializeField] private bool a = false;
       [SerializeField] private bool e = false;
       [SerializeField] private bool i = false;
       [SerializeField] private bool o = false;
       [SerializeField] private bool u = false;
    */


   

   [SerializeField] private bool a = false;
   [SerializeField] private bool e = false;
   [SerializeField] private bool i = false;
   [SerializeField] private bool o = false;
   [SerializeField] private bool u = false;

   [SerializeField] private int grade = 9;

    private string letra = "j";

    [SerializeField] private int day = 31;
    [SerializeField] private int month = 12;
    [SerializeField] private int year = 2023;

   [SerializeField] private float num3;
   [SerializeField] private float num4;

   [SerializeField] private int age = 65;

   [SerializeField] private string range;

   



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

       if (letra == "a") 
       {
            Debug.Log("Es vocal");
       }
       else if (letra == "e")
       {
            Debug.Log("Es vocal");
       }
       else if (letra == "i")
       {
            Debug.Log("Es vocal");
       }
       else if (letra == "o")
       {
            Debug.Log("Es vocal");
       }
       else if (letra == "u")
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

    private void Ae()
    {


        if (age > 65)
        {
            if (range == "gold")
            {
                Debug.Log("75% de descuento");
            }
            if (range == "silver")
            {
                Debug.Log("50% de descuento");
            }
            if (range == "bronze")
            {
                Debug.Log("25% de descuento");
            }

        }
        else if (age < 65)
        {
            if (range == "gold")
            {
                Debug.Log("50% de descuento");
            }
            if (range == "silver")
            {
                Debug.Log("25% de descuento");
            }
            if (range == "bronze")
            {
                Debug.Log("15 de descuento");
            }
        }
        else
        {
            Debug.Log("No puede ser socio");
        }


        if (month <= 12 && month >= 1)
        {
            if (day <= 31)
            {
                Debug.Log("El dia existe");
            }

            if (month == 1)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 2)
            {
                if (day <= 28 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 3)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 4)
            {
                if (day <= 30 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 5)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 6)
            {
                if (day <= 30 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 7)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 8)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 9)
            {
                if (day <= 30 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 10)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 11)
            {
                if (day <= 30 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }
            if (month == 12)
            {
                if (day <= 31 && day >= 1)
                {
                    Debug.Log("El dia existe");
                }
            }

            {
                //Debug.Log($"{num3} % {num4} = {num3 % num4}");
            }
        }
    }
}



    

