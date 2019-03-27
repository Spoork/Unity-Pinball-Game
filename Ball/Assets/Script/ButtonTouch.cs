using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonTouch : MonoBehaviour
{

    public GameObject Sphere;

        private void OnTriggerEnter(Collider other) {
         if(other.gameObject.CompareTag("Player"))
         {
             transform.GetComponent<Renderer>().material.color = Color.green;
         }
    }
}   

