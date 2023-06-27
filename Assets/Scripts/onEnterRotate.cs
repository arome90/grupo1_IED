using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class onEnterRotate : MonoBehaviour
{

    [SerializeField] private GameObject[] activeElements;
    [SerializeField] private GameObject[] rotateElements;

    private bool areRotating = false;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (areRotating)
        {
            foreach (var element in rotateElements)
            {
                element.transform.Rotate(0, 50 * Time.deltaTime,0 );
            }
        }
        
    }

    private void OnTriggerEnter(Collider other)
    {
        foreach (var element in activeElements)
        {
            element.SetActive(true);
        }
        this.areRotating = true;
    }

    private void OnTriggerExit(Collider other)
    {
        foreach (var element in activeElements)
        {
            element.SetActive(false);
        }
        this.areRotating = false;
    }
}
