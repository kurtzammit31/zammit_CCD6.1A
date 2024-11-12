using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.UI;

public class MainScript : MonoBehaviour
{
    Dog d; //Dog is a data type
    Bird b; //Bird is a data type
    public TextMeshProUGUI DogText;
    public TextMeshProUGUI BirdText;
    public Button DogPlayButton, DogSleepButton, DogFeedButton, BirdPlayButton, BirdSleepButton, BirdFeedButton, PlayAllbutton;
    List<Pet> pets = new List<Pet>();

    // Start is called before the first frame update
    void Start()
    {
        d = new Dog("Ginger",1,5,5,5);
        pets.Add(d); //Add new dog to the list

        //d.setName("Ginger");
        //d.setAge(1);
        //d.setHappinessLevel(5);
        //d.setEnergyLevel(5);
        //d.setBarkingLevel(5);

        b = new Bird("Skye",3,5,5,15);
        pets.Add(b); //Add new bird to the list

        //b.setName("Skye");
        //b.setAge(3);
        //b.setHappinessLevel(5);
        //b.setEnergyLevel(5);
        //b.setWingSpan(15);

        DogPlayButton.GetComponent<Button>().onClick.AddListener(PlayEvent);
        BirdPlayButton.GetComponent<Button>().onClick.AddListener(PlayEventBird);
        DogFeedButton.GetComponent<Button>().onClick.AddListener(FeedEvent);
        BirdFeedButton.GetComponent<Button>().onClick.AddListener(FeedEventBird);
        DogSleepButton.GetComponent<Button>().onClick.AddListener(SleepEvent);
        BirdSleepButton.GetComponent<Button>().onClick.AddListener(SleepEventBird);
        PlayAllbutton.GetComponent<Button>().onClick.AddListener(playAllEvent);
    }
    void PlayEvent()
    {
        d.play();
    }

    void SleepEvent()
    {
        d.sleep();
    }

    void FeedEvent()
    {
        d.feed();
    }

    void PlayEventBird()
    {
        b.play();
    }

    void SleepEventBird()
    {
        b.sleep();
    }

    void FeedEventBird()
    {
        b.feed();
    }

    void playAllEvent()
    {
        foreach(Pet pet in pets)
        {
            pet.play();//polymorphism
        }
    }

    // Update is called once per frame
    void Update()
    {
        DogText.text = d.GetInfo();
        BirdText.text = b.GetInfo();
    }
}