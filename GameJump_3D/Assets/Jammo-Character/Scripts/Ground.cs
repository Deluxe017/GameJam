using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Ground : MonoBehaviour
{
    public static bool isGround;

    private void OnTriggerEnter(Collider other)
    {
        isGround = true;
    }
    private void OnTriggerExit (Collider collision)
    {
        isGround = false;
    }
}
