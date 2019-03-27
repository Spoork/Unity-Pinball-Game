using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Wall : MonoBehaviour
{
    public GameObject b1,b2,b3;
    
    private void OnCollisionEnter(Collision other) {
        Color green = Color.green;
               
              if(   b1.GetComponent<Renderer>().material.color == green &&
                    b2.GetComponent<Renderer>().material.color == green &&
                    b3.GetComponent<Renderer>().material.color == green
                )  
                {
                    return;
                }
                if( b1.GetComponent<Renderer>().material.color == green ||
                    b2.GetComponent<Renderer>().material.color == green ||
                    b3.GetComponent<Renderer>().material.color == green
                )
            {
                b1.transform.GetComponent<Renderer>().material.color = Color.red;
                b2.transform.GetComponent<Renderer>().material.color = Color.red;
                b3.transform.GetComponent<Renderer>().material.color = Color.red;
            } 
  
    }

}
