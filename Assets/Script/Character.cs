using System.Collections.Generic;
using UnityEngine;

public class Character : MonoBehaviour
{
    public string Name { get; set; }

    private void Start()
    {
        Name = "Fadhli";
        Debug.Log(Name);
        Car newCar = new Car
                            ("Toyota",
                            "Avanza",
                            "Blue",
                            120,
                            "B 1234 XYZ");
        Debug.Log(newCar.Name);
        newCar.Name = "Supra";
    }
}
