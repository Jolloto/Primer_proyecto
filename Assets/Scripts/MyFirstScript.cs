using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEditor.VersionControl;
using UnityEngine;

public class MyFirstScript : MonoBehaviour
{
    /*
     * Comentario linea 1
     * Comentario linea 2
     * Comentario linea 3
     */

    /*
    // Variable que representa la edad de un jugador
    [SerializeField] private int age = 18;
    // Variable que representa la velocidad del jugador
    [SerializeField] private float speed = 1.5f;
    // Varaible que representa si el jugador esta muerto o vivo
    [SerializeField] private bool isGameOver = false;
    // Variable que representa el nombre del jugador
    [SerializeField] private string username; // = "";
    */

    [SerializeField] private int num1;
    [SerializeField] private int num2;

    [SerializeField] private int coins; 
    
    [SerializeField] private int hour;

    [SerializeField] private float num;

    [SerializeField] private int lives;

    private void Start()
    {
        /*
        Debug.Log(message:"Hola, mundo!");
        Debug.Log(username);
        Debug.Log(age);
        Debug.Log(speed);
        Debug.Log(isGameOver);

        //Forma 1
        Debug.Log(message:$"El nombre de usuario es:{username}");
        //Forma 2
        Debug.Log(message:string.Format("La velocidad del usuario es {0} m/s", speed));
        Debug.Log(message: string.Format("El usuario {0} va a {1} m/s",username, speed));

        //Forma 3
        Debug.Log(message:"El usuario tiene " + age + " años.");
        */

        /*
         * Debug.Log($"Monedas: {coins}");
         coins = coins + 10;
         coins += 10;
        Debug.Log($"Monedas: {coins}");
         */

        // +=
               
         

        /*
        Debug.Log(message:2 + 5);
        Debug.Log(message:num1 + num2);
        Debug.Log(message:num1 + 10);

        Debug.Log(message:$"{num1} + {num2} = {num1 + num2}");
        Debug.Log(message:$"{num1} - {num2} = {num1 - num2}");
        Debug.Log(message:$"{num1} * {num2} = {num1 * num2}");
        Debug.Log(message:$"{num1} / {num2} = {num1 / num2}");

        //  +=
        coins = coins + 5;
        coins += 5;

        coins += 1;
        coins++;

        // -=
        coins = coins - 5;
        coins -= 5;

        coins -= 1;
        coins--;

        // *=
        coins = coins * 5;
        coins *= 5;

        // /=
        coins = coins / 5;
        coins /= 5;
         */

        /*
         // 0, 1, 2, 3, 4
        Debug.Log(hour % 5);
         */


        /*
        // OPERADORES CONDICIONALES
        // IGUALDAD ==
        // TRUE si los objetos son iguales
        // FALSE si los objetos son diferentes
        //Debug.Log(num1 == num2);

        // DESIGUALDAD !=
        // TRUE si los objetos son diferentes
        // FALSE si los objetos son iguales
        //Debug.Log(num1 != num2);

        // MENOR <
        // true si el número de la izquierda es mas pequeño que el de la derecha
        // false si el numero de la izquierda es mayor o igual al de la derecha
        Debug.Log(message: num1 < num2);

        // MAYOR >
        // true si el número de la izquierda es mas grande que el de la derecha
        // false si el numero de la izquierda es menor o igual al de la derecha
        Debug.Log(num1 > num2)

        // MENOR O IGUAL <=
        // true si el numero de la izquierda es menor o igual al de la derecha
        // false si el numero de la izquieda es 
        Debug.Log(message: num1 <= num2);

        // MAYOR O IGUAL >=
        // true si el numero de la izquierda es mayor o igual al de la derecha
        // false si el numero de la izquierda es menor al de la derecha
        Debug.Log(num1 >= num2);
        */

        if (num2 > 0)
        {
            Debug.Log($"{num}es positivo");
         }

        if (lives <= 0)
        {
            Debug.Log("GAME OVER");
        }

    }


}
