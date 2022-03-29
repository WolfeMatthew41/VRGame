using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectRebound : MonoBehaviour
{
   public float speedModifier= 0.3f;

    void OnTriggerEnter(Collider col){
        if(col.tag == "Paintball"){
         //Debug.Log(col.GetComponent<Rigidbody>().velocity);
         gameObject.GetComponent<Rigidbody>().velocity= col.GetComponent<Rigidbody>().velocity * speedModifier;
        }       
    } 


}
