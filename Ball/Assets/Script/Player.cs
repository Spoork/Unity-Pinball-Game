using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Player : MonoBehaviour
{
    public GameObject thumbsup;
    int x = 0;
    private void OnTriggerEnter(Collider other) {
        if(other.gameObject.CompareTag("pCube")){
        if (gameObject != null){
        Destroy(other.gameObject);
        }
        x = 1;
        }
        else if(other.gameObject.CompareTag("yCube") && x == 1){
        if (gameObject != null){
        Destroy(other.gameObject);
        }
        thumbsup.SetActive(true);
        }
    
    }
}
