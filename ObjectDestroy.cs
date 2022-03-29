using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectDestroy : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Paintball")
             damageObject();
           
    } 


   void damageObject(){
      Destroy(gameObject);

   }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
