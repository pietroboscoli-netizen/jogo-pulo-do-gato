using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Item : MonoBehaviour
{
    public gamecontrou gamecontrou;
    private void Awake()
    {
        gamecontrou = GameObject.Find("gamemaneger").GetComponent<gamecontrou>();
        Invoke("IrJogarNoVasco", 5);


    }
    private void IrJogarNoVasco()
    {
        gamecontrou.ItensColetados();
        Destroy(gameObject);

    }

}





