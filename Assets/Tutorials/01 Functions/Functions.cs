using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Functions : MonoBehaviour {
    
    
    void Start() {
    }

    
    void Update() {
        if (Input.GetKeyDown(KeyCode.Space)) 
        {
            GdjeSam(this.gameObject);       // this zna�i: onak kojem je pridru�ena ova skripta (u editoru)
                                            // u ovom slu�aju je to Main Camera
        
        }
    }

    void GdjeSam(GameObject nesto) {
        Debug.Log("Position: " + nesto.transform.position);
    }
}
