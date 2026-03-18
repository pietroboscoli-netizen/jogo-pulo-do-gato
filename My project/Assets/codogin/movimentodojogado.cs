using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.UIElements;
using UnityEngine.WSA;

public class movimentodojogado : MonoBehaviour
{
    public Rigidbody2D rbd2;
    public SpriteRenderer sprite;

    public float velicidade = 5f;
    public float forcadopulo = 5f;
    public bool estanocha;
    public float raiodeverificarchao = 0.2f;
    public Transform antevoo;
    public LayerMask chaollaier;
    public gamecontrou gamecontrouo;
    public Animator anin;
    public bool DIGITOU=false;
    public bool animacaosecreta = false;
    private void Update()
    {
        Andar();
        estanocha = Physics2D.OverlapCircle(antevoo.position, raiodeverificarchao, chaollaier);
        if (DIGITOU == false)
        {
            if (animacaosecreta == false)
            {
                animacaosecreta = true;
                anin.Play("TEMPOPERSONAGEM");
            }
        }
        else 
        {
            animacaosecreta = false;
            anin.Play("personagemanimaça");     
        
        }
        
        if (Input.GetButtonDown("pulo") && estanocha)
        {
            rbd2.velocity = new Vector2(rbd2.velocity.x, forcadopulo);
            DIGITOU = true;
        }
    }

    private void Andar()
    {
        float Andarx = Input.GetAxis("Horizontal") * velicidade;
        float Andary = rbd2.velocity.y;
        if (Andarx > 0)
        {
            DIGITOU = true;
            sprite.flipX = false;
        }
        else if (Andarx < 0)
        {
            sprite.flipX = true;
            DIGITOU=true;
        }
        else
        {
            DIGITOU =false;
        }
        rbd2.velocity = new Vector2(Andarx, Andary);


    }
    private void OnDrawGizmosSelected()
    {
        Gizmos.color = Color.green;
        Gizmos.DrawWireSphere(antevoo.position, raiodeverificarchao);


    }
    void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.tag == "inimigo")
        {


            gamecontrouo.RecuberDano(1);



        }
        else if (collision.tag == "item")
        {
            gamecontrouo.ReceberPontos(100);
            gamecontrouo.ItensColetados();
            Destroy(collision.gameObject);
        }
        if (collision.tag == "fim")
        {
            gamecontrouo.Morrer();



        }

    }






































































}
