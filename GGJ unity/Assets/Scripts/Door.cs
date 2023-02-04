using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update

    private Animator DoorAnimation;

    public GameObject[] DoorArray;
    public bool DoorActive;
    private bool SwitchBool;

    private int DoorArraySize;

    void Start()
    {
        DoorAnimation = GetComponent<Animator>();
        DoorArraySize = DoorArray.Length;
    }

    // Update is called once per frame
    void Update()
    {
        for (int i = 0; i < DoorArraySize; i++)
        {
            if (DoorArray[i].GetComponent<Switch>().SwitchOn == false)
            {
                DoorActive = false;
                break;
            }

            DoorActive = true;
        }

        if (DoorActive)
        {
            DoorAnimation.SetBool("IsOpen", true);
        }
    }
}
