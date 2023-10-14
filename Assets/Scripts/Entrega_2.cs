using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega_2 : MonoBehaviour
{
    [SerializeField] private float num1;
    [SerializeField] private float num2;

    [SerializeField] private string name;

    [SerializeField] private int num3;
    [SerializeField] private int num4;
    
    private float result;

    

    private void Start()
    {
       Debug.Log($"{num1} + {num2} = {num1 + num2}");
       Debug.Log(num1 >= num2);
       
       result = num1 + num2;
       Debug.Log(result);

       Debug.Log(name);

       Debug.Log($"Bienvenido: {name}");
    }

    

        

    
}
