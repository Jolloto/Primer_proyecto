using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Entrega3_Act9 : MonoBehaviour
{
    
    private int age = 65;
    private int age2 = 18;

    private bool gold = false;
    private bool silver = false;
    private bool bronze = false;




    void Start()
    {
        if (age || gold)
        {
            Debug.Log("Tienes 75% de descuento");
        }
    }

    
}
