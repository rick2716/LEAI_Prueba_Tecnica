using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Sumatoria : MonoBehaviour
{
    public TMP_InputField numerosInput; 
    public TMP_Text numerosRandomTxt;
    public TMP_Text sumatoriaTxt;

    public void GenerarNumeros()
    {
        if (int.TryParse(numerosInput.text, out int n) && n >= 1 && n <= 20)
        {
            int sum = 0;
            string numeros = "Números generados: ";

            for (int i = 0; i < n; i++)
            {
                int randomNum = Random.Range(1, 101);
                numeros += randomNum + " ";
                sum += randomNum;
            }

            numerosRandomTxt.text = numeros;
            sumatoriaTxt.text = sum.ToString();
        }
        else
        {
            numerosRandomTxt.text = "Por favor, ingrese un número entre 1 y 20.";
            sumatoriaTxt.text = "";
        }
    }
}
