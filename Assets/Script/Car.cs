using UnityEngine;

public class Car
{
    private string _manufacture;
    private string _name;
    private string _color;
    private float _speed;
    private string _licensePlate;
    private bool _isLightOn;
    private bool _isWiperOn;

    // Property
    public string Name
    {
        get
        {
            return _manufacture + " " + _name;
        }
        set
        {
            _name = value;
        }
    }

    public Car()
    {

    }

    public Car(string manufacture, string name, string color, float speed, string licensePlate)
    {
        _manufacture = manufacture;
        _name = name;
        _color = color;
        _speed = speed;
        _licensePlate = licensePlate;
    }

    public void StartEngine()
    {
        Debug.Log("Car engine is starting");
    }

    public void Throttle()
    {
        Debug.Log("Car is moving");
    }

    public void Brake()
    {
        Debug.Log("Car is stopped");
    }

    public void SetWiper()
    {
        _isWiperOn = !_isWiperOn;
        Debug.Log("Wiper is " + _isWiperOn);
    }

    public void SetLight()
    {
        _isLightOn = !_isLightOn;
        Debug.Log("Light is " + _isLightOn);
    }
}
