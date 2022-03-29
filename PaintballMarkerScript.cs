using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.XR.Interaction.Toolkit;

public class PaintballMarkerScript : MonoBehaviour
{



    public GameObject paintBallMakerPrefab;
    public GameObject projectilePrefab;

    [Range(0.0f, 5.0f)]
    public float projectileForce;

    [Range(0.03f, 10.0f)]
    public float projectileScale;

    [Range(0.55f, 10f)]
    public float projectileColliderRadius;

   public AudioClip shot;

    private bool wielding;
    private GameObject objectInHand;
    private Rigidbody rb;
    private Transform projectileSpawn;

   private AudioSource source;
   private bool triggerDown= false;

   void OnTriggerEnter(Collider col){
      if(col.tag == "PaintballMarker"){
         //Debug.Log("Entered");
         objectInHand= col.gameObject;
      }
   }

   void OnTriggerExit(Collider col){
      if(col.tag == "PaintballMarker"){
         //Debug.Log("Exited");
         objectInHand= null;
      }
   }


    void Awake()
    {
        rb = GetComponent<Rigidbody>();
        objectInHand = null;
        source= GetComponent<AudioSource>();

    }

    // Update is called once per frame
    void Update ()
    {

        if (objectInHand && triggerDown)
        {

            Transform trigger = objectInHand.transform.GetChild(1);
            trigger.localEulerAngles = Vector3.right * 20;

                //projectileSpawn.transform.localPosition = Vector3.forward * 0.533f * projectileScale;

                GameObject projectile = Instantiate(projectilePrefab, projectileSpawn);
                Rigidbody projectileRB = projectile.GetComponent<Rigidbody>();
                projectile.transform.localScale = Vector3.one * projectileScale;
                projectile.GetComponent<SphereCollider>().radius = projectileColliderRadius;
                projectile.transform.parent = null;         
                projectile.transform.position= objectInHand.transform.GetChild(2).position;
                projectile.transform.rotation= objectInHand.transform.rotation;
                projectileRB.AddRelativeForce(Vector3.forward * 1000 * projectileForce);
                source.Play();
         }

    }




   void OnTrigger(){
      triggerDown= !triggerDown;


   }



}
