using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinearInterpolation : MonoBehaviour
{/*
    // Start is called before the first frame update
    void Start()
    {
        //In this case, result = 4
        float result = Mathf.Lerp(3f, 5f, 0.5f);
        //Mathf.Lerp function takes 3 float parameters:
        //one representing the value to interpolate from;
        //another representing the value to interpolate to
        //and a final float representing how far to interpolate.
       // Example below
        Vector3 from = new Vector3 (1f, 2f, 3f);
        Vector3 to = new Vector3(5f, 6f, 7f);

        // Here result = (4, 5, 6)
        Vector3 result = Vector3.Lerp(from, to, 0.75f);
        //hese work in exactly the same way as Mathf.Lerp but the ‘from’ and ‘to’
        //values are of type Color and Vector3 respectively. The third parameter in
        //each case is still a float representing how much to interpolate. The result
        //of these functions is finding a colour that is some blend of two given colours
        //and a vector that is some percentage of the way between the two given vectors.
    }

    // Update is called once per frame
    void Update()
    {
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f);
        // The one above is dependent on frame and the one below is dependent on time
        light.intensity = Mathf.Lerp(light.intensity, 8f, 0.5f * Time.deltaTime);
        //Follows same principle as lerp since colours are represented as
        //floats starting off at 0 and go towards 8 but rate of change
        //will be slow. Note that this  can be code dependent or time dependent.
    }*/
}
