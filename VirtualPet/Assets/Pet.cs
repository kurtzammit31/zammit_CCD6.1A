using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pet
{
    string name;
    int age;
    int happinessLevel;
    int energyLevel;

    public void feed()
    {
        energyLevel += 1;
        happinessLevel += 1;
    }

    public void play()
    {
        happinessLevel += 1;
        energyLevel -= 1;
    }

    public void sleep()
    {
        energyLevel += 1;
    }
}

