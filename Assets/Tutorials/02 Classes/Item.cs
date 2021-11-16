using UnityEngine;
using System.Collections;

[System.Serializable]               // da bi se vidjelo u editoru. Public NIJE dovoljan za klase
public class Item                   // Nema ": MonoBehaviour" jer ne nasljedjuje ništa od unitija
                                    // Ovo je putpuno nova, custom klasa
{
    public int itemID;
    public string itemName;
    public string itemDescription;

    // CONSTRUCTOR je posebna funkcija (metoda) koja se definira ovdje i izvršava se prilikom 
    // kreiranja novog objekta klase

    // ima JEDNAKI NAZIV kao i klasa

    public Item(int id, string name, string description) {
        this.itemID = id;
        this.itemName = name;
        this.itemDescription = description;
    }

    // Jos jedan constructor s manje parametara
    // Method OVERLOAD!!!
    
    public Item(int id, string name) {
        this.itemID = id;
        this.itemName = name;
    }

}

[System.Serializable]
public class Osoba {
    public int starost;
    public string spol;
    public string location;
}