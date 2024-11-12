using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bird : Pet
{
    int wingSpan;

    public Bird() { }
    public Bird(string name, int age, int happinessLevel, int energyLevel, int wingSpan) : base(name, age, happinessLevel, energyLevel)
    {
        this.wingSpan = wingSpan;
    }

    public void setWingSpan(int NewWingSpan)
    {  wingSpan = NewWingSpan; }

    public override void play()
    {
        setEnergyLevel(GetEnergyLevel() - 2);
        setHappinessLevel(GetHappinessLevel() + 1);
    }

    public int GetWingSpan()
    {
        return wingSpan;
    }
    public int calculateHumanYears()
    {
        return GetAge() * 10;
    }

    public new string GetInfo()
    {
        return base.GetInfo() +
                "\nWingspan: " + wingSpan + "\n";
                
    }
}