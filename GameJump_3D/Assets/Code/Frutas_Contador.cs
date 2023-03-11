using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class Frutas_Contador : MonoBehaviour
{
    private int Score_M;
    private int Score_C;
    private int Score_W;
    public TextMeshProUGUI Manzanas;
    public TextMeshProUGUI Melon;
    public TextMeshProUGUI Cereza;
    void Start()
    {
        Score_M = 0;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Manzana")
        {
            Score_M++;
            Manzanas.text = "Manzanas = " + "" + Score_M;
        }
        if (collision.gameObject.tag == "Melon")
        {
            Score_C++;
            Melon.text = "Melon = " + "" + Score_C;
        }
        if (collision.gameObject.tag == "Cereza")
        {
            Score_W++;
            Cereza.text = "Cereza = " + "" + Score_W;
        }
    }
}
