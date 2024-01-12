using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting.FullSerializer;
using UnityEngine;

public class Object 
{
    // Fields
    private string _name;
    private string _description;
    private string _type;
    private string _color;

    // Properties
    public string Name  
    {
        get { return _name; }
        set { _name = value; }
    }

    public string Description
    {
        get { return _description; }
        set { _description = value; }
    }

    public string Type
    {
        get { return _type; }
        set { _type = value; }
    }

    public string Color
    {
        get { return _color; }
        set { _color = value; }
    }

    // Constructors
    public Object(string name, string description, string type, string color)
    {
        _name = name;
        _description = description;
        _type = type;
        _color = color;
    }
    

    // Methods
    public virtual string DisplayInfo()
    {
       return $"Name: {Name}, Description: {Description}, Type: {Type}, Color: {Color} ";
    }
    
    public virtual float CalculateVolume()
    {
        return 0f;
    }
}



public class Sphere : Object
{
    // Fields
   private float _radius;

    // Properties
    public float Radius
    {
        get { return _radius; }
        set { _radius = value; }
    }

    // Constructors
    public Sphere(string name, string description, string type, string color, float radius) : base(name, description, type, color)
    {
        _radius = radius;
    }

    // Methods
    public override float CalculateVolume()
    {
        float volume = (4f / 3f) * Mathf.PI * Mathf.Pow(_radius, 3);
        return volume;
    }

    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Radius: {Radius}, Volume: {CalculateVolume()} ";
    }
}



public class Cube : Object
{
    // Fields
    private float _length;

    // Properties
    public float Length
    {
        get { return _length; }
        set { _length = value; }
    }

    // Constructors
    public Cube(string name, string description, string type, string color, float length) : base(name, description, type, color)
    {
        _length = length;
    }

    // Methods

    public override float CalculateVolume()
    {
        float volume = Mathf.Pow(_length, 3);
        return volume;
    }

    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Length: {Length}, Volume: {CalculateVolume()} ";
    }
}



public class Cylinder : Object
{
    // Fields
    private float _cylinderRadius;
    private float _cylinderHeight;

    // Properties
    public float Radius
    {
        get { return _cylinderRadius; }
        set { _cylinderRadius = value; }
    }

    public float Height
    {
        get { return _cylinderHeight; }
        set { _cylinderHeight = value; }
    }

    // Constructors
    public Cylinder(string name, string description, string type, string color, float radius, float height) : base(name, description, type, color)
    {
        _cylinderRadius = radius;
        _cylinderHeight = height;
    }

    // Methods

    public override float CalculateVolume()
    {
        float volume = Mathf.PI * Mathf.Pow(_cylinderRadius, 2) * _cylinderHeight;
        return volume;
    }

    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Radius: {Radius}, Height: {Height}, Volume: {CalculateVolume()} ";
    }
}


public class Capsule : Object
{
    // Fields
    private float _capsuleRadius;
    private float _capsuleHeight;

    // Properties

    public float Radius
    {
        get { return _capsuleRadius; }
        set { _capsuleRadius = value; }
    }

    public float Height
    {
        get { return _capsuleHeight; }
        set { _capsuleHeight = value; }
    }

    // Constructors
    public Capsule(string name, string description, string type, string color, float radius, float height) : base(name, description, type, color)
    {
        _capsuleRadius = radius;
        _capsuleHeight = height;
    }

    // Methods
    public override string DisplayInfo()
    {
        return base.DisplayInfo() + $", Radius: {Radius}, Height: {Height}, Volume: {CalculateVolume()} ";
    }

    public override float CalculateVolume()
    {
        float volume = (4f / 3f) * Mathf.PI * Mathf.Pow(_capsuleRadius, 3) + Mathf.PI * Mathf.Pow(_capsuleRadius, 2) * _capsuleHeight;
        return volume;
    }
}
