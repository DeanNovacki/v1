using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Upravljanje : MonoBehaviour {
    public Kvadar[] element = new Kvadar[5];

    void Start() {
        element[0] = new Kvadar(1, "kockica");
        element[1] = new Kvadar(1, "kocka", 2f, 0f, 1f);


    }

    // Update is called once per frame
    void Update() {

    }



}
