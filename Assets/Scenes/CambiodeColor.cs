using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CambiodeColor : MonoBehaviour
{
        public Material materialCuboVerde;
        public Material materialCuboRojo;

        public MeshRenderer mesh;

        public void CambioMaterialVerde()
        {
            mesh.material = materialCuboVerde;
        }
        public void CambioMaterialRojo()
        {
            mesh.material = materialCuboRojo;
        }

        private void OnTriggerEnter(Collider other)
        {
            CambioMaterialVerde();
        }

        private void OnTriggerExit(Collider other)
        {
            CambioMaterialRojo();
        }
}
