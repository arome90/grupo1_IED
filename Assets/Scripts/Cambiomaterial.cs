using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Cambiomaterial : MonoBehaviour
{
    public Material materialcuboverde;
    public Material materialcuborojo;

    public MeshRenderer mesh;

    public void cambiomaterialverde()
    {
        mesh.material = materialcuboverde;

    }

    public void Cambiomaterialrojo()
    {
        mesh.material = materialcuborojo;

    }

    private void OnTriggerEnter(Collider other)
    {
        cambiomaterialverde();

    }

    private void OnTriggerExit(Collider other)
    {
        Cambiomaterialrojo();

    }
}
