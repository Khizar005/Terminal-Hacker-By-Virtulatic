using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Hacker : MonoBehaviour
{
    private readonly string greeting = "Hello Khizar";
    void Start()
    {
        Into();
    }

    private void Into()
    {
        Terminal.ClearScreen();
        Terminal.WriteLine(greeting);
        Terminal.WriteLine("Hello world");
    }

}
