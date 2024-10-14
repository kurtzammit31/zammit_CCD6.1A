using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class KillBall : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(1))
        {
            Vector3 mousePosition = Input.mousePosition; //get mouse location

            //convert from screen space to world space
            Vector3 inWorldSpace = Camera.main.ScreenToWorldPoint(mousePosition);
            inWorldSpace.z = 0; //make ball between background and camera

            //check if this ball is close enought to the click
            float distance = Vector3.Distance(mousePosition, this.gameObject.transform.position);

            if(distance > 0.5)
            {
                Destroy(this.gameObject);   
            }

        }
    }
}
