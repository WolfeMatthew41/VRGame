using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonObjects : MonoBehaviour
{

   public GameObject gravityOnButton= null;
   public GameObject gravityOffButton= null;


   public static bool isGravity= true;
   public static bool springLeftLaunch= false;
   public static bool springLeftReady= true;
   public static bool springRightLaunch= false;
   public static bool springRightReady= true;


    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Paintball")
             if(gameObject.tag == "GravityButton") { //Turning on and off the gravity
                gravitySwitch();
             }
             else { //Activating the spring switch
                springSwitch();
             }
           
    }    


   void gravitySwitch(){//================================================================Gravity Switch
      if(gameObject.name == "Button Gravity On"){//====================================Switching Back On
         if(!isGravity){ //If gravity is off
            if(gravityOffButton){
               Vector3 offset= new Vector3(0.4f, 0f, 0f);
               gravityOffButton.transform.position+= offset;
            }
            Vector3 temp= new Vector3(-0.4f, 0f, 0f);
            gameObject.transform.position+= temp;
            ButtonObjects.isGravity= true;
         }
      }
      else if(gameObject.name == "Button Gravity Off"){//================================Switching Off
         if(isGravity){ //If gravity is on
            if(gravityOnButton){
               Vector3 offset= new Vector3(0.4f, 0f, 0f);
               gravityOnButton.transform.position+= offset;
            }
            Vector3 temp= new Vector3(-0.4f, 0f, 0f);
            gameObject.transform.position+= temp;
            ButtonObjects.isGravity= false;
         }
      }
   }


   void springSwitch(){//==================================================================Spring Switch
      if(gameObject.name == "Button Spring Left"){//=========================================Left Spring
         if(springLeftReady){
Debug.Log(ButtonObjects.springLeftReady);
            Vector3 temp= new Vector3(-0.4f, 0f, 0f);
            gameObject.transform.position+= temp;
            ButtonObjects.springLeftReady= false;
            ButtonObjects.springLeftLaunch= true;

         }
      }
      else if(gameObject.name == "Button Spring Right"){//====================================Right Spring
         if(springRightReady){
            Vector3 temp= new Vector3(-0.4f, 0f, 0f);
            gameObject.transform.position+= temp;
            ButtonObjects.springRightReady= false;
            ButtonObjects.springRightLaunch= true;
         }
      }
   }


    // Start is called before the first frame update===================================================
    void Start()
    {
       if(gameObject.name == "Button Gravity On" && isGravity){
          Vector3 temp= new Vector3(-0.4f, 0f, 0f);
          gameObject.transform.position+= temp; //Default value is -5.6 for being pushed out
       }

        
    }


}
