using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;

public class Costeo : MonoBehaviour
{
    [Header("Valores")]
    public TMP_Text materiaPrimaTxt;
    public TMP_Text manoObraTxt;
    public TMP_Text cifTxt;
    public TMP_Text utilidadTxt;
    private float materiaPrima;
    private float manoObra;
    private float cif;
    private float utilidad;

    [Header("Inputs")]
    public TMP_InputField costoTotalInput;
    public TMP_InputField utilidadEsperadaInput;
    public TMP_InputField precioVentaInput;

    [Header("Respuestas")]
    public TMP_Text costoTotalRes;
    public TMP_Text utilidadEsperadaRes;
    public TMP_Text precioVentaRes;
    private float costoTotalReal;
    private float utilidadEsperadaReal;
    private float precioVentaReal;

    // Start is called before the first frame update
    void Start()
    {
        GenerarValores();
        CalcularValores();
    }

    public void GenerarValores()
    {
        materiaPrima = Random.Range(100000f, 500001f);
        manoObra = Random.Range(100000f, 500001f);
        cif = Random.Range(100000f, 500001f);
        utilidad = Random.Range(50f, 120f);

        materiaPrimaTxt.text = materiaPrima.ToString("F2");
        manoObraTxt.text = manoObra.ToString("F2");
        cifTxt.text = cif.ToString("F2");
        utilidadTxt.text = utilidad.ToString("F2");
    }

    public void CalcularValores()
    {
        costoTotalReal = materiaPrima + manoObra + cif;
        Debug.Log("Costo Total "+ costoTotalReal);

        utilidadEsperadaReal = costoTotalReal * (utilidad / 100f);
        Debug.Log("Utilidad Esperada "+ utilidadEsperadaReal);

        precioVentaReal = costoTotalReal + utilidadEsperadaReal;
        Debug.Log("Precio Venta "+ precioVentaReal);
    }

    public void ComprobarValores()
    {
        float costoTotalUsuario = float.Parse(costoTotalInput.text);
        float utilidadUsuario = float.Parse(utilidadEsperadaInput.text);
        float precioVentaUsuario = float.Parse(precioVentaInput.text);

        if (Mathf.Approximately(costoTotalUsuario, costoTotalReal))
        {
            costoTotalRes.text = "Correcto";
        }
        else
        {
            costoTotalRes.text = "Valor correcto: " + costoTotalReal;
        }
            
        if (Mathf.Approximately(utilidadUsuario, utilidadEsperadaReal))
        {
            utilidadEsperadaRes.text = "Correcto";
        }
        else
        {
            utilidadEsperadaRes.text = "Valor correcto: " + utilidadEsperadaReal;
        }
            
        if (Mathf.Approximately(precioVentaUsuario, precioVentaReal))
        {
            precioVentaRes.text = "Correcto";
        }
        else
        {
            precioVentaRes.text = "Valor correcto: " + precioVentaReal;
        }
    }
}
