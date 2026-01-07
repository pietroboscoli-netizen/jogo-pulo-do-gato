using System.Collections;
using System.Collections.Generic;
using UnityEditor.U2D;
using UnityEngine;

public class movimentodojogado : MonoBehaviour
{
   public Rigidbody2D rbd2;
   public SpriteRenderer sprite;

   public float velicidade =5f;
   public float forcadopulo = 5f;

    private void Update()
    {
        Andar();


    }

   private void Andar()
   {
      float Andarx = Input.GetAxis("Horizontal")* velicidade; 
      float Andary = rbd2.velocity.y;
      if(Andarx > 0)
      {
         sprite.flipX = false;
      }
      else if(Andarx < 0)
      {
         sprite.flipX=true;

      }
      rbd2.velocity=new Vector2(Andarx,Andary);
   
   
   }

   


}
