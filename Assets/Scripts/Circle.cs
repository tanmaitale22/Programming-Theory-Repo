using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Circle : Shape
{
    private void Start()
    {
        shapeName = "Circle";
        shapeColor = Color.red;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a Circle!");
    }
}
