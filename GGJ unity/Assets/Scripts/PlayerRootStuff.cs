using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerRootStuff : MonoBehaviour
{
    public GameObject RootPrefab;
    public Transform RootSummonPos;
    public bool RootExists = false;
    public Vector3 RootedPlayerPos;
    public GameObject ClonePrefab;
    public bool CloneExists = false;

    // Update is called once per frame
    void Update()
    {
        if (Input.GetButtonDown("Fire1") && RootExists == false && CloneExists == false)
        {
            Instantiate(RootPrefab, RootSummonPos.position, RootSummonPos.rotation);
            RootedPlayerPos = transform.position;
            RootExists = true;
        }
        else if (Input.GetButtonDown("Fire1") && RootExists == true && CloneExists == false)
        {
            Instantiate(ClonePrefab, transform.position, transform.rotation);
            transform.position = RootedPlayerPos;
            RootExists = false;
            CloneExists = true;
        }
        else if (Input.GetButtonDown("Fire1") && RootExists == false && CloneExists == true)
        {
            CloneExists = false;
        }
    }
}
