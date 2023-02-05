using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button : MonoBehaviour
{
    private Animator ButtonAnims;

    public bool IsPressed = false;

    // Start is called before the first frame update
    void Start()
    {
        ButtonAnims = GetComponent<Animator>();
    }

    // Update is called once per frame
    void OnTriggerEnter2D(Collider2D other)
    {
        if (IsPressed == false)
        {
            ButtonAnims.SetBool("IsPressed", true);
            IsPressed = true;
        }
    }

    void OnTriggerExit2D(Collider2D other)
    {
        if (IsPressed == true)
        {
            ButtonAnims.SetBool("IsPressed", false);
            IsPressed = false;
        }
    }
}
