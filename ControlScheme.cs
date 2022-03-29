using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;
using UnityEngine.SceneManagement;

public class ControlScheme : MonoBehaviour
{


   public PlayerInput playerInput;
   public string controlScheme;


    // Start is called before the first frame update
    void Start()
    {
        playerInput = GetComponent<PlayerInput>();

        playerInput.SwitchCurrentControlScheme(controlScheme);
        
    }

    void OnRestartButton() {
        SceneManager.LoadScene(0);
    }
}
