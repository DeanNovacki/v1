using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
    
    
    void Start() {
    }

    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GdjeSam(this.gameObject);       // this znaèi: onak kojem je pridružena ova skripta (u editoru)
                                            // u ovom sluèaju je to Main Camera
        
        }
    }

    void GdjeSam(GameObject nesto) {
        Debug.Log("Position: " + nesto.transform.position);
    }
}
