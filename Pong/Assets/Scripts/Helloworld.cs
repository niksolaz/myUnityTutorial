using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour {

    private int somma;
    private string message;

    string[] Stati = { "Francia", "Italia", "Germania", "Inghilterra" };

    private void Start()
    {
        for (int i = 0; i <= 10; i++){
            print(somma);
            somma += 1;
        }

        message = "Salve Mondo";
        print(message);

        for (int i = 0; i < Stati.Length; i++) { 
            print(Stati[i]); 
        }

        int x = 5;

        x++;

        Resetta(x);

        x++;

        print(x);

    }

    public void Resetta( int i ){
        i = 0;
        print(i);
    }
}
