using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCloneStuff : MonoBehaviour
{
    public GameObject RootSprite;
    public Transform RootSummonPoint;

    public bool RootExists = false;
    
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetButtonDown("Fire1") && RootExists == false)
        {
            Instantiate(RootSprite, RootSummonPoint.position, RootSummonPoint.rotation);
            RootExists = true;
        }
        else if(Input.GetButtonDown("Fire1") && RootExists == true)
        {
            
            RootExists = false;
        }

    }
}
