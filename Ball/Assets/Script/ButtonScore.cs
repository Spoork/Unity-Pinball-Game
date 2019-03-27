using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonScore : MonoBehaviour
{
    public GameObject b1,b2,b3, wall, yCube, pCube;
    public float myTime = 5;
    
    

    // Update is called once per frame
    void Update()
    {
        
        Color green = Color.green;
            
                if( b1.GetComponent<Renderer>().material.color == green &&
                    b2.GetComponent<Renderer>().material.color == green &&
                    b3.GetComponent<Renderer>().material.color == green)
                    {
                        myTime = myTime - Time.deltaTime;
                         if(myTime > 0)
                        {
                        wall.transform.Translate(-0.005f, 0, 0);            
                        }
                        if(yCube != null)
                        yCube.SetActive(true);
                        if(pCube != null)
                        pCube.SetActive(true);
                    }
                
    }

}
