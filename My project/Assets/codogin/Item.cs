using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    private void Awake()
    {
        Invoke("IrJogarNoVasco",5);
   
    
    }
    private void IrJogarNoVasco()
    {
        Destroy(gameObject);

    }



































}







