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

    //[SerializeField] private int angle1;
    //[SerializeField] private int angle2;
    //[SerializeField] private int angle3;   
    [SerializeField] private int b;
    [SerializeField] private int height;

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
     SumaDia(day, month, year);
     RestaDia(day, month, year);
    //isValidTriangle(angle1, angle2, angle3);
     AreaTriangle(b,height);

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

         if(cond1 && cond2) 
         {
            return true;
          
         } 
         else if(cond2)
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

    private void SumaDia(int day, int month, int year)
    {
        day = day + 1;

        if (month == 1 || month == 3 || month == 5 || month == 7 || month == 8 || month == 10 || month == 12)
        {
            if (day > 31)
            {
                day = 1;
                month = month + 1;
                if (month >= 12)
                {
                    day = 1;
                    month = 1;
                    year = year + 1;
                }
            }
        }
        if (month == 2 || month == 4 || month == 6 || month == 9 || month == 11)
            if (day > 30)
            {
                day = 1;
                month = month + 1;
                if (month > 12)
                {
                    day = 1;
                    month = 1;
                    year = year + 1;
                }
            }

        Debug.Log(message: $"{day}/{month}/{year}");
    }
     
    //A6 

    private void RestaDia(int day, int month, int year)
    {
        day = day - 1;

        if (month == 2 || month == 4 || month == 6 || month == 8 || month == 9 || month == 11)
        {
            if (day <  1)
            {
                day = 31;
                month = month - 1;
                
            }
        }
        else if (month == 1)
            {
            if (day < 1) 
            {
                day = 31;
                month = 12;
                year--;
            }
            else if (month == 3) 
            {
                day = 28;
                month = 2;
            }
            if (month == 5 || month == 7 || month == 10 || month == 12)
                if (day < 1)
                {
                if (day < 1) 
                { 
                    day = 30;
                    month = month - 1;
                }
        

                Debug.Log(message: $"{day}/{month}/{year}");
        }

    //A7

    private string AnosChinos(int year)
    {
        string[] anoschinos = { "rata", "buey", "tigre", "conejo", "dragón", "serpiente", "caballo", "cabra", "mono", "gallo", "perro", "cerdo" };

        int pos = (year - 1912) % 12;

        Debug.Log("El año chino para el año: " + year.ToString() + " es " + anoschinos[pos] + ".");
        return anoschinos[pos];
     }     

      //A8

      /*
      bool isValidTriangle(int angle1, int angle2, int angle3)
      {
         if((angle1 + angle2 + angle3) != 180)
         {
            return false;
         } 
         else
         {
            return true;
         }

         
      }
      */

      private int AreaTriangle(int b, int height)
      {
         int result = (b * height) / 2;
         
         return result;
         
      }
      


      //A9

      string Nota(int grade)
      {
         if (grade < 5)
         {
            Debug.Log("D");
            return "D";
         }
         else if (grade < 7)
         {
            Debug.Log ("C");
            return "C";
         }
         else if (grade < 9)
         {
            Debug.Log("B");
            return"B";
         }
         else if (grade <= 10)
         {
            Debug.Log("A");
            return "A";
         }
         else
         {
            Debug.Log("Pon la nota bien.");
            return "Pon la nota bien.";
         }
      }


      //A10

      private bool IsEven(int num3)
      {
         if (num3 % 2 == 0)
         {
            return true;
         }
         else
         {
            return false;
         }
      }
}


     

   

