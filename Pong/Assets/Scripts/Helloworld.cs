using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Helloworld : MonoBehaviour {

    public bool choise = false;

    private void Start()
    {
        if(choise){
            print("The choise is true");
        }else{
            print("The choise is false");
        }
        Car firstCar = new Car("Opel","Corsa","XXXXXXX");
        Car superCar = new Car("Batmobile", "Deluxe", "BATMAN90");

        print(firstCar.getBrand());
        print(firstCar.getModel());
        print(firstCar.getPlate());

        print(superCar.getBrand());
        print(superCar.getModel());
        print(superCar.getPlate());
    }
}
