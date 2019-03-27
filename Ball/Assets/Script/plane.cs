using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class plane : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        float xR = Input.GetAxis("Vertical");
        float zR = Input.GetAxis("Horizontal");
        
        transform.Rotate(xR, 0 , -zR);
    }
}
