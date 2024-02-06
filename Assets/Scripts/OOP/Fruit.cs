/*****************************************************************************
// File Name :         Fruit.cs
// Author :            Mitchell Menke
// Creation Date :     January 25, 2024
//
// Brief Description : In class activity document to demonstrate constructors
                       and deconstructors.
*****************************************************************************/
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Fruit
{
    public string name;
    public string color;
    public float weight;
    

    
    public Fruit(string name, string c, float w)  //THIS IS A CONSTRUCTOR
    {
        this.name = name;  //MAKE SURE TO USE THIS.VARIABLE IF WORKING WITH SAME NAME
        color = c;
        weight = w;
    }

    public Fruit()
    {
        name = "banana";
        color = "blue";
        weight = 3.7f;
    }

    public Fruit(string name)
    {
        this.name = name;
        color = "red";
        weight = 1.0f;
    }

    public Fruit(float weight)
    {
        name = "watermelon";
        color = "white";
        this.weight = weight;
    }

    ~Fruit()
    {
        //maybe write to a file
        name = "0";
        weight = 0f;
        color = "clear";
    }

}
