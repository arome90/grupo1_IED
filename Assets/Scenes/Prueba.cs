using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Prueba : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

        public string scene; // Nombre de la escena a la que deseas cambiar

        public void ChangeToScene()
        {
            SceneManager.LoadScene(scene); // Cambia a la escena con el nombre especificado
        }

        private void OnTriggerEnter(Collider other)
        {
            ChangeToScene();

        }
    
}
