using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class GravitySwitch : MonoBehaviour
{

   private Rigidbody gravitySwitch;

    // Start is called before the first frame update
    void Start()
    {
        if(SceneManager.GetActiveScene().name == "Warehouse"){
           gravitySwitch= gameObject.GetComponent<Rigidbody>();
        }  
    }

    // Update is called once per frame
    void Update()
    {
        if(SceneManager.GetActiveScene().name == "Warehouse"){
           if(!ButtonObjects.isGravity){
              gravitySwitch.useGravity= false;
           }
           else{
              gravitySwitch.useGravity= true;
           }
        }
    }
}
