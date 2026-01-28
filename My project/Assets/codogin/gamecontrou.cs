using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;
using UnityEngine.UI;

public class gamecontrou : MonoBehaviour
{
   public int vida=10;
   public int pontos=0;
   public Text txtpontos;
   public Text txtvida;
    void Start()
    {
        vida=10;
        pontos=0;

    }

    void Update()
    {
        txtpontos.text=pontos.ToString();
        txtvida.text=vida.ToString();
    }
    



}
