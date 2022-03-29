using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBallSplatterSfx : MonoBehaviour
{

   public AudioClip splatter;

   public static bool splat= false;

   private AudioSource source;


   void playSplatter(){
      source.Play();
      splat= false;
   }




    // Start is called before the first frame update
    void Awake()
    {
           source= GetComponent<AudioSource>();   
    }

    // Update is called once per frame
    void Update()
    {
        if(splat){
           playSplatter();
        }
    }
}
