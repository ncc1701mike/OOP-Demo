using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrimitiveManager : MonoBehaviour
{
    public GameObject[] primitives; // Assign your primitives in the Inspector
    private int currentIndex = 0;

    void Start()
    {
        ShowOnlyCurrentPrimitive();
    }

    void Update()
    {
        // Right Click to switch primitives
        if (Input.GetMouseButtonDown(1)) // Right click
        {
            SwitchToNextPrimitive();
        }

        // Spin the current primitive
        if (primitives[currentIndex] != null)
        {
            Vector3 worldYAxis = Vector3.up;
            float rotationSpeed = 20f;
            primitives[currentIndex].transform.RotateAround(Vector3.zero, worldYAxis, rotationSpeed * Time.deltaTime); // Adjust rotation speed as needed
        }
    }

    void SwitchToNextPrimitive()
    {
        // Hide current primitive
        primitives[currentIndex].SetActive(false);

        // Move to the next primitive
        currentIndex = (currentIndex + 1) % primitives.Length;

        // Show next primitive
        ShowOnlyCurrentPrimitive();
    }

    void ShowOnlyCurrentPrimitive()
    {
        foreach (var primitive in primitives)
        {
            primitive.SetActive(false);
        }
        primitives[currentIndex].SetActive(true);
    }
}
