using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpringLaunch : MonoBehaviour
{

   private Rigidbody springBody;
   public float springForce= 5000.0f;
   public GameObject springObject;


   void OnTriggerEnter(Collider col){
      if(col.gameObject.name == "Floor Spring Collision"){
         if(gameObject.name == "Spring Top Left"){
               ButtonObjects.springLeftReady= true;
               ButtonObjects.springLeftLaunch= false;
               Vector3 offset= new Vector3(0.4f, 0f, 0f);
               springObject.transform.position+= offset;
         }
         else{
            ButtonObjects.springRightReady= true;
            ButtonObjects.springRightLaunch= false;
         }
      }
   }

    // Start is called before the first frame update
    void Start()
    {
        springBody= GetComponent<Rigidbody>();
    }

    // Update is called once per frame
    void Update()
    {
         if(gameObject.name == "Spring Top Left"){
            if(ButtonObjects.springLeftLaunch == true){
               springBody.velocity= new Vector3(0, springForce * Time.fixedDeltaTime, 0);
               ButtonObjects.springLeftLaunch= false;
            }

         }
         else{
            if(ButtonObjects.springRightLaunch == true){
            }
         }
    }


}
