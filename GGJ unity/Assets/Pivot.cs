using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pivot : MonoBehaviour
{

    void FixedUpdate()
    {
        //Get the difference of the position of the mouse on the window and the objects position
        Vector3 difference = Camera.main.ScreenToWorldPoint(Input.mousePosition) - transform.position;
        difference.Normalize();

        //Calculate the angle between the difference
        float rotationZ = Mathf.Atan2(difference.y, difference.x) * Mathf.Rad2Deg;

        //Rotate the object accordingly
        transform.rotation = Quaternion.Euler(0f, 0f, rotationZ - 90f);
    }
}