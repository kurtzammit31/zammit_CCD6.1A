using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Pet
{
    string name;
    int age;
    int happinessLevel;
    int energyLevel;

    public Pet(string name, int age, int happinessLevel, int energyLevel)
    {
        this.name = name;
        this.age = age;
        this.happinessLevel = happinessLevel;
        this.energyLevel = energyLevel;
    }

    public Pet() { } //parameter-less constructor

    //getter
    public string GetName()
    {
        return name;
    }

    //setter
    public void setName(string NewName)
    { name = NewName; }

    //getter
    public int GetAge()
    {
        return age;
    }

    //setter
    public void setAge(int NewAge)
    { if(NewAge >= 0)
        age = NewAge; 
    }

    //getter
    public int GetHappinessLevel()
    {
        return happinessLevel;
    }

    //setter
    public void setHappinessLevel(int NewHappinessLevel)
    { happinessLevel = NewHappinessLevel; }

    //getter
    public int GetEnergyLevel()
    {
        return energyLevel;
    }

    //setter
    public void setEnergyLevel(int NewEnergyLevel)
    { energyLevel = NewEnergyLevel; }

    public void feed()
    {
        energyLevel += 1;
        happinessLevel += 1;
    }

    public abstract void play();

    public void sleep()
    {
        energyLevel += 1;
    }

    public string GetInfo()
    {
        return "Name: " + name +
               "\nAge: " + age +
               "\nHappiness: " + happinessLevel +
               "\nEnergy: " + energyLevel;
    }
}

