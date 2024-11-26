using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Triangle : Shape
{
    private void Start()
    {
        shapeName = "Triangle";
        shapeColor = Color.green;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a Triangle!");
    }
}