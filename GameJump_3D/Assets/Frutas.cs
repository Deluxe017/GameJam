using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Frutas : MonoBehaviour
{
    public void OnTriggerEnter(Collider other)
    {
        if(Input.GetKey("f"))
        {
            Destroy(this.gameObject, 0.1f);
        }
    }
}
