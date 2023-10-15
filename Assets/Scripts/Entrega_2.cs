using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_2 : MonoBehaviour
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;

    [SerializeField] private string name;
    [SerializeField] private string text;

    [SerializeField] private int num3;
    [SerializeField] private int num4;
    
    private float result;

    

    private void Start()
    {
       // La suma de las dos primeras variables 
       Debug.Log($"{num1} + {num2} = {num1 + num2}");
       
       // La comparacion de si la 1a variable es mayor o igual a la 2a variable
       Debug.Log(num1 >= num2);
       
       // Mostrar el resultado de las 2 primeras variables
       result = num1 + num2;
       Debug.Log(result);

       // Variable que te deja poner un nombre
       Debug.Log(name);
       
       // Dejar un mensaje de bienvenido en la consola
       Debug.Log($"Bienvenido: {name}");
       
       // Resultado de calcular las variables
       Debug.Log(num1 % num2);
       Debug.Log(num3 % num4);
       
       // Dejar un mensaje en la consola de presentacion con las variables de name y text
       Debug.Log($"Hola! Mi nombre es {name}, donde {text}");
    }

    

        

    
}
