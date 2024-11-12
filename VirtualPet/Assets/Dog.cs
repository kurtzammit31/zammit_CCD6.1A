using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Dog : Pet
{
    int barkinglevel;

    public Dog() { }
    public Dog(string name, int age, int happinessLevel, int energyLevel, int barkinglevel): base(name,age,happinessLevel,energyLevel)
    {
        this.barkinglevel = barkinglevel;
    }

    public void setBarkingLevel(int NewBarkingLevel)
    { barkinglevel = NewBarkingLevel; }

    public override void play()
    {
        setEnergyLevel(GetEnergyLevel() -1);
        setHappinessLevel(GetHappinessLevel() +2);
    }

    public int GetBarkingLevel()
    {
        return barkinglevel;
    }
    public int calculateHumanYears()
    {
        return GetAge() * 7;
    }

    public new string GetInfo()
    {
        return base.GetInfo() +
                    "\nBarking Level: " + barkinglevel + "\n";
                
    }
}


