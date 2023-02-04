using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Switch : MonoBehaviour
{
    private Animator SwitchAnims;

    public bool SwitchOn = false;


    // Start is called before the first frame update
    void Start()
    {
        SwitchAnims = GetComponent<Animator>();
    }

    void OnTriggerEnter2D(Collider2D other)
    {
        if (SwitchOn == false)
        {
            SwitchAnims.SetBool("SwitchOn", true);
            SwitchOn = true;
        }
    }
}
