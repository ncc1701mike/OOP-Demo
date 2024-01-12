using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectWrapper : MonoBehaviour
{
    public Object myObject;
    
    void Start()
    {
       if (gameObject.name == "Sphere")
       {
            myObject = new Sphere("Sphere", "Spherical 3D object", "Unity Primitive", "White", 0.5f);
       }
       else if (gameObject.name == "Cube")
       {
            myObject = new Cube("Cube", "Cubic 3D object", "Unity Primitive", "Red", 0.95f);
       }
       else if (gameObject.name == "Cylinder")
       {
            myObject = new Cylinder("Cylinder", "Cylindrical 3D object", "Unity Primitive", "Blue", 0.375f, 1f);
       }
       else if (gameObject.name == "Capsule")
       {
            myObject = new Capsule("Capsule", "Capsular 3D object", "Unity Primitive", "Green", 0.5f, 2f);
       }
       

    }
}
