using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;

public class ObjectSelector : MonoBehaviour
{
    public GameObject uiPanel;
    public TextMeshProUGUI nameText;
    public TextMeshProUGUI descriptionText;
    public TextMeshProUGUI typeText;
    public TextMeshProUGUI colorText;
    public TextMeshProUGUI radiusText;
    public TextMeshProUGUI heightText;
    public TextMeshProUGUI lengthText;
    public TextMeshProUGUI volumeText;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0)) // If the left mouse button is clicked
        {
            // Create a ray from the camera to the mouse cursor
            Ray ray = Camera.main.ScreenPointToRay(Input.mousePosition);
            RaycastHit hit;

            // If the ray hits an object
            if (Physics.Raycast(ray, out hit))
            {
                ObjectWrapper objectComponent = hit.transform.gameObject.GetComponent<ObjectWrapper>();
                if (objectComponent != null)
                {
                    DisplayInfo(objectComponent);
                }
            }
        }
    }

    void DisplayInfo(ObjectWrapper objectInfo)
    {
        if (objectInfo != null && objectInfo.myObject != null)
        {
            // Update properties common to all classes
            nameText.text = "Name: " + objectInfo.myObject.Name;
            descriptionText.text = "Description: " + objectInfo.myObject.Description;
            typeText.text = "Type: " + objectInfo.myObject.Type;
            colorText.text = "Color: " + objectInfo.myObject.Color; 

            // Reset properties common to subclasses
            radiusText.text = "";
            heightText.text = "";
            lengthText.text = "";
            volumeText.text = "";


            if (objectInfo.myObject is Sphere sphere)
            {
                radiusText.text = "Radius: " + sphere.Radius.ToString();
                volumeText.text = "Volume: " + sphere.CalculateVolume().ToString();
            }
            else if (objectInfo.myObject is Cube cube)
            {
                lengthText.text = "Length: " + cube.Length.ToString();
                volumeText.text = "Volume: " + cube.CalculateVolume().ToString();
            }
            else if (objectInfo.myObject is Cylinder cylinder)
            {
                radiusText.text = "Radius: " + cylinder.Radius.ToString();
                heightText.text = "Height: " + cylinder.Height.ToString();
                volumeText.text = "Volume: " + cylinder.CalculateVolume().ToString();
            }
            
            else if (objectInfo.myObject is Capsule capsule)
            {
                radiusText.text = "Radius: " + capsule.Radius.ToString();
                heightText.text = "Height: " + capsule.Height.ToString();
                volumeText.text = "Volume: " + capsule.CalculateVolume().ToString();
            }
            
            uiPanel.SetActive(true);
        }
    }
    
}
