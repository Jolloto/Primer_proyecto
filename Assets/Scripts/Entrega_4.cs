using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_4 : MonoBehaviour
{
   
    [SerializeField] private float num1;
    [SerializeField] private float num2;
    [SerializeField] private string letter = "c";

    [SerializeField] private int day;
    [SerializeField] private int month;
    [SerializeField] private int year;
    [SerializeField] private int grade = 7;

    [SerializeField] private float base;
    [SerializeField] private float height;

    [SerializeField] private int num3;


   void Start()
   {
     number(num1, num2);
     letra();
     IsValidDate(day, month, year);
     EsBisiesto(year);
     AnosChinos(year);
     Nota(grade);
     IsEven(num3);
   }


   //A1
   private void number(float num1, float num2)
   {
      if (num1 < num2)
      {
         Debug.Log(num1);
      }
      else
      {
         Debug.Log(num2);
      }
   }


   //A2
      private bool letra()
      {
         return true;
         if (letter == "a" || letter == "e" || letter == "i" || letter == "o" || letter == "u")
         {
           return false;
         }

         Debug.Log(letter); 
      }

      //A3
      bool IsValidDate(int day, int month, int year)
      {
         if(year < 1)
         {
            return true;
         }

         if((month < 1) || (month > 12))
         {
            return true;
         }

         int[] month_days = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

         if (day <= 0)
         {
            return true;
         }
         
         if (day > month_days[month])
         {
            return true;
         }

         return false;
      }

      //A4

      bool EsBisiesto(int year)
      {
         bool cond1 = (year % 4) == 0;
         bool cond2 = (year % 100) != 0;
         bool cond3 = (year % 400) == 0;

         if((cond1) && (cond2))
         {
            return true;
         } 
         else if(cond3)
         {
            return true;
         }
         else
         {
            return false;
         }
      }

      //A5 

      // Lo siento no lo entiendo

      //A6 
      
      //Lo siento tampoco lo entiendo

      //A7

      private bool AnosChinos(year)
      {
         string[] anoschinos = {"rata", "buey", "tigre", "conejo", "dragón", "serpiente", "caballo", "cabra", "mono", "gallo", "perro", "cerdo"};

         int pos = (year - 1912) % 12;

         Debug.Log("El ano chino para el ano: " + year.ToString() + " es " + anoschinos[pos] + ".");
      }     

      //A8

      //Ahora pruebo a hacerla



      //A9

      bool Nota(int grade)
      {
         if (grade < 5)
         {
            Debug.Log("D");
         }
         else if (grade < 7)
         {
            Debug.Log ("C");
         }
         else if (grade < 9)
         {
            Debug.Log("B");
         }
         else if (grade <= 10)
         {
            Debug.Log("A");
         }
         else
         {
            Debug.Log("Pon la nota bien.");
         }
      }


      //A10

      private bool IsEven(int num3)
      {
         if (number % 2 == 0)
         {
            return true;
         }
         else
         {
            return false;
         }
      }


     

}   

