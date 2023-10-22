using System.Collections;
using System.Collections.Generic;
using System.Runtime.CompilerServices;
using UnityEditor.VersionControl;
using UnityEngine;

public class Funciones : MonoBehaviour
{

    private int myNumber = 7;
    private void Start()
    {
        /*
            SayHelloTo(name: "Royito");
            SayHelloTo(name: "Ceci");
            SayHelloTo(name: "Marki Marki");
            SayHelloTo(name: "Yohuas");

            Debug.Log($"La suma de los 3 numeros es: {SumThreeIntNumbers(19, 22, 43)}");
    

            Debug.Log(ShowUserInfo("emesefe",45));
            

        
            Calculator(5, 3);
            Calculator(10, 7);
            Calculator(90, 23);

            Debug.Log(Hello)
         */
        
    }

    // Sin outputs y sin inputs
    private void HelloWorld() 
    {
        // Cuerpo de la funcion
        Debug.Log(message:"Hello World");
    }

    // Sin outputs y con inputs
   private void SayHelloTo (string name) 
    {
        Debug.Log(message: $"Hello, {name}");
    }

    // Con outputs y con inputs
    private int SumThreeIntNumbers(int num1, int num2, int num3) 
    {
        int result = num1 + num2 + num3;
        return result;
    }

    // Con outputs y sin inputs
    //private string

}
