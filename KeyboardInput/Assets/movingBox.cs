using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UIElements;

public class movingBox : MonoBehaviour
{
    float xMin, yMin, xMax, yMax;
    // Start is called before the first frame update
    void Start()
    {
        Vector3 topLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 1, 0));
        Vector3 topRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 1, 0));
        Vector3 bottomLeft = Camera.main.ViewportToWorldPoint(new Vector3(0, 0, 0));
        Vector3 bottomRight = Camera.main.ViewportToWorldPoint(new Vector3(1, 0, 0));

        xMin = topLeft.x; //or bottomLeft.x
        xMax = topRight.x; //or bottomRight.x
        yMin = bottomLeft.y; //or bottomRight.x
        yMax = topLeft.y; //or topRight.x
    }

    // Update is called once per frame
    void Update()
    {
       
        
        if (Input.GetKeyDown(KeyCode.UpArrow)){
            this.transform.position = new Vector3(this.transform.position.x,
                                                  this.transform.position.y + 1,
                                                  this.transform.position.z);
            
        }

        if (Input.GetKeyDown(KeyCode.DownArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x,
                                                  this.transform.position.y - 1,
                                                  this.transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.LeftArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x - 1,
                                                  this.transform.position.y,
                                                  this.transform.position.z);

        }

        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            this.transform.position = new Vector3(this.transform.position.x + 1,
                                                  this.transform.position.y,
                                                  this.transform.position.z);

        }
    }
}
