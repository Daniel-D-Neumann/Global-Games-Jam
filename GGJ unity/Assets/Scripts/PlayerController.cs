using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerController : MonoBehaviour
{
    public CharacterController2D Controller;

    public float Speed = 40f;

    float HoriMovement = 0f;
    
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        HoriMovement = Input.GetAxisRaw("Horizontal") * Speed;
    }

    void FixedUpdate()
    {
        Controller.Move(HoriMovement * Time.fixedDeltaTime, false, false);
    }
}
