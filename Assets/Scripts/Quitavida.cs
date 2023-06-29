using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Quitavida : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        other.GetComponent<Vidas>().quitarVida();

    }
}
