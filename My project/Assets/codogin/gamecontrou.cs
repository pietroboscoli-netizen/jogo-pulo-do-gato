
using System.Collections;
using System.Collections.Generic;
using System.IO;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;

public class gamecontrou : MonoBehaviour
{
    public int vida = 10;
    public int pontos = 0;
    public int MaxItems = 5;
    public int QntdeItenss = 0;
    public Text txtpontos;
    public Text txtvida;
    public GameObject item;
    public GameObject menu;
    private IEnumerator coroutine;
    void Start()
    {
        vida = 10;
        pontos = 0;
        menu.SetActive(true);
        Time.timeScale = 0;
        coroutine = CriarItensComOTempoPresisoEONesesario();
        StartCoroutine(coroutine);


    }

    void Update()
    {
        txtpontos.text = "pontos: "+pontos.ToString();
        txtvida.text = "vida: "+vida.ToString();

    }
    public void RecuberDano(int receber)
    {
        vida -= receber;
        if (vida <= 0)
        {
            Morrer();
        }

    }
    public void ReceberPontos(int receberpopntods)
    {
        pontos += receberpopntods;

    }
    public void CriarItem()
    {
        float x = Random.Range(-9, 9);
        float y = Random.Range(0, 5);



        Vector2 posisaoaleotoria = new Vector2(x, y);
        Instantiate(item, posisaoaleotoria, Quaternion.identity);
        QntdeItenss++;
    }
    public void ItensColetados()
    {
        QntdeItenss--;



    }

    private IEnumerator CriarItensComOTempoPresisoEONesesario()
    {
        while (true)
        {
            yield return new WaitForSeconds(0.5f);
            if (QntdeItenss < MaxItems)
            {
                CriarItem();
            }


        }

    }
    public void PlayGame()
    {
        menu.SetActive(false);
        Time.timeScale = 1;
    }
    public void Morrer()
    {
        SceneManager.LoadScene(0);


    }


}




