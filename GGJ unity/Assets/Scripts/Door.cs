using System.Collections;
using System.Collections.Generic;
using System.Drawing;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Door : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject[] DoorArray;
    public int SceneToLoad;

    private Animator DoorAnimation;
    private bool DoorActive;
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
            if (DoorArray[i].gameObject.tag == "Switch")
            {
                if (DoorArray[i].GetComponent<Switch>().SwitchOn == false)
                {
                    DoorActive = false;
                    break;
                }
            }

            if (DoorArray[i].gameObject.tag == "Button")
            {
                if (DoorArray[i].GetComponent<Button>().IsPressed == false)
                {
                    DoorActive = false;
                    break;
                }
            }

            DoorActive = true;
        }

        if (DoorActive)
        {
            DoorAnimation.SetBool("IsOpen", true);
        }
        else
        {
            DoorAnimation.SetBool("IsOpen", false);
        }
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (other.gameObject.tag == "Player" && DoorActive == true)
        {
            SceneManager.LoadScene(SceneToLoad);
        }
    }
}
