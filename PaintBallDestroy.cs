using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBallDestroy : MonoBehaviour
{


    void OnTriggerEnter(Collider col)
    {
        if(col.tag != "PaintballMarker")
             splatterBall();
           
    } 


   void splatterBall(){
      PaintBallSplatterSfx.splat= true;
      Destroy(gameObject);
   }



}
