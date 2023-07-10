using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class loading : MonoBehaviour
{
    public float rotationSpeed = 10f; // Speed of rotation

    private RectTransform rectTransform;

    private void Start()
    {
        rectTransform = GetComponent<RectTransform>();
    }

    private void Update()
    {
        // Rotate the rectTransform around the Z-axis
        rectTransform.Rotate(0f, 0f, rotationSpeed * Time.deltaTime);
    }
}