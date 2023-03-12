using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class Frutas_Contador : MonoBehaviour
{
    [SerializeField] private int Score_M;  
    [SerializeField] private int Score_C;
    [SerializeField] private int Score_W;
    [SerializeField] private int Money;

    public TextMeshProUGUI Manzanas;
    public TextMeshProUGUI Melon;
    public TextMeshProUGUI Cereza;
    public TextMeshProUGUI Money_;

    public GameObject Manzana_image;
    public GameObject Cherry_image;
    public GameObject Melon_image;

    void Start()
    {
        Score_M = 0;
    }
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.tag == "Manzana")
        {
            Score_M++;
            Manzanas.text = "" + Score_M;
            Manzana_image.SetActive(true);
            
        } 
        if (collision.gameObject.tag == "Melon")
        {
            Score_C++;
            Melon.text = "" + Score_C;        
            Melon_image.SetActive(true);
        }
        if (collision.gameObject.tag == "Cereza")
        {
            Score_W++;
            Cereza.text = "" + Score_W;
            Cherry_image.SetActive(true);
        }

        // Dinero 
        if(collision.gameObject.tag == "Money")
        {
            if(Score_M > 0) 
            {
               Score_M--;
               Manzanas.text = "" + Score_M;

                if(Score_M == 0)
                {
                    Money += 10;
                    Money_.text = "Dinero = " + "" + Money;
                }
            }
            if (Score_C > 0)
            {
               Score_C--;
               Cereza.text = "" + Score_C;

                if (Score_C >= 0)
                {
                    Money += 10;
                    Money_.text = "Dinero = " + "" + Money;
                }
            }
            if (Score_W > 0)
            {
                Score_W--;
                Melon.text = "" + Score_W;

                if (Score_W >= 0)
                {
                    Money += 10;
                    Money_.text = "Dinero = " + "" + Money;
                }
            } 
        }
    }
}
