using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Car{
    private string model;
    private string brand;
    private string plate;

    public Car(string model, string brand, string plate){
        this.model = model;
        this.brand = brand;
        this.plate = plate;
    }

    public string getModel(){
        return model;
    }

    public string getBrand(){
        return brand;
    }

    public void setPlate(string plate){
        this.plate = plate;
    }

    public string getPlate(){
        return plate;
    }

}
