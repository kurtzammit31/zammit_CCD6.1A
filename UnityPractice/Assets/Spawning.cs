using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawning : MonoBehaviour
{
    public GameObject BallPrefab; //variable declaration
    public static int count = 0;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetMouseButtonDown(0)) //0 means left-click
        {
            Vector3 mousePosition = Input.mousePosition; //get mouse location

            //convert from screen space to world space
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
            inWorldSpace.z = 0; //make ball between background and camera

            //Spawn a ball using the prefab
            if (count < 5)
            {
                Instantiate(BallPrefab, inWorldSpace, Quaternion.identity);
                count++;
            }
             
        }
    }
}
