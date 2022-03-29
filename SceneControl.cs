using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneControl : MonoBehaviour
{



   public string sceneName;



    void OnTriggerEnter(Collider col)
    {
        if(col.tag == "Paintball"){
             ChangeScene();
        }
           
    } 



   public void ChangeScene(){
      SceneManager.LoadScene(sceneName);
   }

}
