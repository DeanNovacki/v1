using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class Player : MonoBehaviour {

    public Item[] items = new Item[5];        // kreiranje 5 objekata klase Item

    public Osoba[] ljudi;       // kreiranje objekata klase Osoba

    // Start is called before the first frame update
    void Start()
    {
        items[0] = new Item(59, "mile", "èoek");
        items[1] = new Item(55, "Dean");   
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
