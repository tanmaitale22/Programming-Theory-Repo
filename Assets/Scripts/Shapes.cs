using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Shape : MonoBehaviour
{
    protected string shapeName;
    protected Color shapeColor;

    public virtual void DisplayText()
    {
        Debug.Log("This is a generic shape.");
    }

    public string ShapeName
    {
        get { return shapeName; }
        set
        {
            if (value.Length > 20)
                Debug.LogError("Shape name is too long!");
            else
                shapeName = value;
        }
    }

    public Color ShapeColor
    {
        get { return shapeColor; }
        set { shapeColor = value; }
    }

    // Detect mouse clicks on the shape
    void OnMouseDown()
    {
        DisplayText();  // Polymorphic method to display the appropriate message
    }
}
