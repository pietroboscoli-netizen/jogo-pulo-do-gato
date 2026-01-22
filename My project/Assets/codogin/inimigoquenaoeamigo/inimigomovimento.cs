using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class inimigomovimento : MonoBehaviour
{
    public bool etaindoparaadireita=true;
     public float velocidadedoinimigo=3f; 
     public bool epradestruitrrr=false;   
    public int idadequenosresta=100;
     public Transform ladodomovimento;
        void Start()
    {
        LadoDoMovimento();



    }

    void Update()
    {
        Andar();
  
    }
    public void LadoDoMovimento()
    {
        if (ladodomovimento.position.x >= 10)
        {
            etaindoparaadireita=false;

        }
        else if(ladodomovimento.position.x <= -10)
        {
            etaindoparaadireita=true;
        }

    }
    public void Andar()
    {
        if (etaindoparaadireita == false)
        {
            ladodomovimento.position -=new Vector3(velocidadedoinimigo,0,0)* Time.deltaTime;

        }
        else
        {
                ladodomovimento.position +=new Vector3(velocidadedoinimigo,0,0)* Time.deltaTime;

        }
    }


}
