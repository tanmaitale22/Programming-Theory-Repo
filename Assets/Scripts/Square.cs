using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Square : Shape
{
    private void Start()
    {
        shapeName = "Square";
        shapeColor = Color.blue;
    }

    public override void DisplayText()
    {
        Debug.Log("This is a Square!");
    }
}
