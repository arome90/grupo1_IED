using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Vidas : MonoBehaviour
{
    public int vida = 100;

    public Text vidatext;

    private void Update()
    {
        vidatext.text = "" + vida;

    }
    public void quitarVida ()
    {
        vida = vida - 1;

    }

    public void subirVida ()
    {
        vida = vida + 1;

    }


}
