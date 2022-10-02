using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class ButtonEvent : MonoBehaviour
{
    // Start is called before the first frame update

    private int count = 0;

    public void Atacar()
    {
        
        if (count < 5)
        {
            count++;
            Debug.Log("Ataque "+count);
        }
        else
        {
            Debug.Log("Ha sido destruido por ZEUUUUUUUUUUUUUUUUUUUUUUUUS!!!!!!!!!!!!!!!!!!!!!!!!! ");
        }
        
    }
    public void Defender()
    {
        Debug.Log("Defendiendo");
    }
    public void Escapar()
    {

    }

}
