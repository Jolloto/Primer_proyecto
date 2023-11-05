using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Prueba_Ejercicio : MonoBehaviour
{
  // 1

  [SerializeField] private int num1;
  [SerializeField] private int num2;
  [SerializeField] private int num3;
  [SerializeField] private int num4;
  [SerializeField] private string letra;

  [SerializeField] private float grade;

  [SerializeField] private int day;
  [SerializeField] private int month;
  [SerializeField] private int year;

  [SerializeField] private int angle1;
  [SerializeField] private int angle2;
  [SerializeField] private int angle3;


  //A10
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

  bool EsBisiesto(int year)
  {
    // 1. Divisible entre 4 i no divisible entre 100
    // 2. Divisible entre 400

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
  bool IsValidDate(int day, int month, int year)
  {
    if(year < 1)
    {
      return false;
    }

    if((month < 1) || (month > 12))
    {
      return false;
    }

    int[] month_days = {0, 31, 28, 31, 30, 31, 30, 31, 31, 30, 31, 30, 31};

    if (day <= 0)
    {
      return false;
    }

    if(EsBisiesto(year))
    {
      month_days[2] = 29;
    }
    // INDEXAR un array: variable[posición]
    if (day > month_days[month])
    {
      return false;
    }

    // Si no hem retornat False, retornam True, la data és correcta
    return true;
  }


  void Start()
  {
    // A1

    bool cond1 = (num1 >= num2);

    if (cond1)
    {
      Debug.Log("El número más grande es: " + num1.ToString());
    }
    else    
    {
      Debug.Log("El número más grande es: " + num2.ToString());
    }

    // A2

    bool cond2;

    switch(letra){
      case "a":
        cond2 = true;
        break;
      case "e":
        cond2 = true;
        break;
      case "i":
        cond2 = true;
        break;
      case "o":
        cond2 = true;
        break;
      case "u":
        cond2 = true;
        break;
      default:
        cond2 = false;
        break;
    }

    if (cond2)
    {
     Debug.Log("Es una vocal: " + letra.ToString());
    }
    else    
    {
      Debug.Log("No es una vocal: " + letra.ToString());
    }
  // cond2 = (letra == 'a' or letra == 'e' or letra == 'i' or letra == 'o' or letra == 'u');

    // A3

    bool cond3 = ((num3 % num4) == 0);

    if (cond3)
    {
     Debug.Log(num3.ToString() + " es divisble entre " + num4.ToString());
    }
    else    
    {
      Debug.Log(num3.ToString() + " no es divisble entre " + num4.ToString());
    }

    // A4
    
    if (grade < 0)
    {
      Debug.Log("Pon la nota bien.");
    }  
    else if (grade < 5)
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

    // A5

    if (IsValidDate(day, month, year))
    {
      Debug.Log("La fecha: " + day.ToString() + '/' + month.ToString() + '/' + year.ToString() + " es válida.");
    }
    else 
    {
      Debug.Log("La fecha: " + day.ToString() + '/' + month.ToString() + '/' + year.ToString() + " no es válida.");
    }


    // A6

    string[] anoschinos = {"rata", "buey", "tigre", "conejo", "dragón", "serpiente", "caballo", "cabra", "mono", "gallo", "perro", "cerdo"};

    int pos = (year - 1912) % 12;

    Debug.Log("El ano chino para el ano: " + year.ToString() + " es " + anoschinos[pos] + ".");

    // Com fer-ho amb cadena de if-else:
    // if (pos == 0 ){
    //   Debug.Log("El año chino es rata");
    // }
    // else if (pos == 1){
    //   Debug.Log("El año chino es buey");
    // }
    

    // A7

    if (month == 1) //Gener 
    {
      if (day <= 19)
      {
        Debug.Log("Capricornio");        
      }
      else 
      {
        Debug.Log("Acuario");
      }
      
    } 
    else if (month == 2) //Febrer 
    {
      if (day <= 18)
      {
        Debug.Log("Acuario");        
      }
      else 
      {
        Debug.Log("Piscis");
      }
      
    } 
    else if (month == 3) //Marzo 
    {
      if (day <= 20)
      {
        Debug.Log("Piscis");        
      }
      else 
      {
        Debug.Log("Aries");
      }
      
    } 
    else if (month == 4) //Abril 
    {
      if (day <= 19)
      {
        Debug.Log("Aries");        
      }
      else 
      {
        Debug.Log("Tauro");
      }
      
    } 
    else if (month == 5) //Maig 
    {
      if (day <= 20)
      {
        Debug.Log("Tauro");        
      }
      else 
      {
        Debug.Log("Geminis");
      }
      
    } 
    else if (month == 6) //Juny 
    {
      if (day <= 20)
      {
        Debug.Log("Geminis");        
      }
      else 
      {
        Debug.Log("Cancer");
      }
      
    } 
    else if (month == 7) //Juliol 
    {
      if (day <= 22)
      {
        Debug.Log("Cancer");        
      }
      else 
      {
        Debug.Log("Leo");
      }
      
    } 
    else if (month == 8) //Agosto 
    {
      if (day <= 22)
      {
        Debug.Log("Leo");        
      }
      else 
      {
        Debug.Log("Virgo");
      }
      
    } 
    else if (month == 9) //Septembre 
    {
      if (day <= 22)
      {
        Debug.Log("Virgo");        
      }
      else 
      {
        Debug.Log("Libra");
      }
    }
    else if (month == 10) //Octubre 
    {
      if (day <= 22)
      {
        Debug.Log("Libra");        
      }
      else 
      {
        Debug.Log("Escorpio");
      }
    }
    else if (month == 11) //Novembre 
    {
      if (day <= 21)
      {
        Debug.Log("Escorpio");        
      }
      else 
      {
        Debug.Log("Sagitario");
      }
    }
    else if (month == 12) //Decembre 
    {
      if (day <= 21)
      {
        Debug.Log("Sagitario");        
      }
      else 
      {
        Debug.Log("Capricornio");
      } 
    } 
    






    // A 10

    if (isValidTriangle (angle1, angle2, angle3))
    {
      Debug.Log("El triángulo es válido.");
    }
    else{
      Debug.Log("El triángulo no es válido.");
    }
  }
   
}
