using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class MyScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        float dec = 5.6f;
        Debug.Log(dec);

        string str = "ceci est un test";
        Debug.Log(str);

        short[] tab = { 2, 3, 20, 9};
        Debug.Log(tab[1]);

        string Hi(string Nom) {
            return "Bonjour " + Nom;
        }

        Debug.Log(Hi("Yann"));

        int square(int number) {
            return number*number;
        }

        Debug.Log(square(2));
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Z)) {
            Debug.Log("Vous avez avancé d'une case.");
        }
    }
}