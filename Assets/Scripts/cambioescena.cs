using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class cambioescena : MonoBehaviour
{
    public string scene;

    public void changeScene()
    {
        SceneManager.LoadScene(scene);
    }

    private void OnTriggerEnter(Collider other)
    {
        changeScene();


    }

}
