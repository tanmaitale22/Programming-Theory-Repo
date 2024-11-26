using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShapeController : MonoBehaviour
{
    private Shape currentShape;

    // This method will act as an abstraction for changing the shape's properties
    public void ChangeShape(Shape newShape)
    {
        currentShape = newShape;
        currentShape.DisplayText();
        GetComponent<Renderer>().material.color = currentShape.ShapeColor;
    }

    void OnMouseDown()
    {
        if (currentShape != null)
        {
            currentShape.DisplayText();  // Polymorphic behavior: will call the overridden method
        }
    }
}

