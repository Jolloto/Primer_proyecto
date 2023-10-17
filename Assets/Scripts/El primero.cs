using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class Elprimero : MonoBehaviour
{
    [SerializeField] private bool monday = true;
    [SerializeField] private bool tuesday = false;
    [SerializeField] private bool wednesday = false;
    [SerializeField] private bool thursday = false;
    [SerializeField] private bool friday = false;
    [SerializeField] private bool saturday = false;
    
    [SerializeField] private int lives = 5;
    [SerializeField] private int grade = 7;
   
    [SerializeField] private bool isMonday = false;
    [SerializeField] private bool isTuesday = true;
    [SerializeField] private bool computersWork = true;

    [SerializeField] private bool isGameOver = true;

    [SerializeField] private bool isOnTheFloor = true;
    [SerializeField] private int maxJumps = 2;
    [SerializeField] private int totalJumps = 0;

    void Start()
    {
     
     //OPERADORES DE DECISION


        if (monday)
        {
            Debug.Log("Es lunes");
        } 
        else if (tuesday)
        {
            Debug.Log("Es martes");
        }
          else if (wednesday) 
         {
            Debug.Log("Es miercoles");
         }
          else if (thursday) 
         {
            Debug.Log("Es jueves");
         }
          else if (friday)
        {
            Debug.Log("Es viernes");
        }
          else if (saturday)
        {
            Debug.Log("Es sabado");
        }
        else 
        {
            Debug.Log("Es domingo");
        }


        if (lives <= 0) 
        {
            Debug.Log("Es GAME OVER");
        }
        else if (lives <= 5) 
        {
            Debug.Log("Te quedan pocas vidas ve con cuidado");
        }
        else if (lives <= 9) 
        {
            Debug.Log("Perdiste una vida");
        }

        //Suspenso, Aprovado (>= 5), Notable bajo (=7), alto (=8) (>=7), Excelente (>=9)

        if (grade >= 9)
        {
            Debug.Log("Excelente");
            if (grade == 9)
            {
                Debug.Log("Excelente");
            }
            if (grade == 10)
            {
                Debug.Log("Matricula de honor");
            }
        }
        else if (grade >= 7)
        {
            Debug.Log("Notable");
            if (grade == 8)
            {
                Debug.Log("Notable alto");
            }
            else if (grade == 7)
            {
                Debug.Log("Notable bajo");
            }
        }
        else if (grade >= 5)
        {
            Debug.Log("Aprobado");
            if (grade == 6)
            {
                Debug.Log("Aprovado alto");
            }
            if (grade == 5)
            {
                Debug.Log("Aprovado bajo");
            }
        }
        else 
        {
            Debug.Log("Suspenso");
        }

        // OR (||)
        // c1 || c2
        // t || t -> t
        // t || f -> t
        // f || t -> t
        // f || f -> f

        if (isMonday || isTuesday) 
        {
            if (computersWork) 
            {
                Debug.Log("Hay clase d RPMI");
            }
        }

        if ((isMonday || isTuesday)  && computersWork) 
        {
            Debug.Log("Hay clase de RPMI");
        }
        else 
        {
            Debug.Log("NO hay clase de RPMI");
        }


        // NOT !
        // !true = false
        // !false = true

        if (!isGameOver) 
        {
            Debug.Log("Estamos vivos");
        }


        if (!isOnTheFloor) 
        {
         if (totalJumps < maxJumps) 
         {
                // Saltamos
                totalJumps++;
         }
        }

        

    }

}
