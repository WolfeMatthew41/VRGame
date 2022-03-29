using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PaintBallColor : MonoBehaviour
{

    private int rangeMax = 9;

    public Material mat1;
    public Material mat2;
    public Material mat3;
    public Material mat4;
    public Material mat5;
    public Material mat6;
    public Material mat7;
    public Material mat8;
    public Material mat9;


    // Start is called before the first frame update
    void Awake()
    {
        int choice = Random.Range(1, rangeMax);
        switch (choice) {
            case 1:
                gameObject.GetComponent<Renderer>().material = mat1;
                break;
            case 2:
                gameObject.GetComponent<Renderer>().material = mat2;
                break;
            case 3:
                gameObject.GetComponent<Renderer>().material = mat3;
                break;
            case 4:
                gameObject.GetComponent<Renderer>().material = mat4;
                break;
            case 5:
                gameObject.GetComponent<Renderer>().material = mat5;
                break;
            case 6:
                gameObject.GetComponent<Renderer>().material = mat6;
                break;
            case 7:
                gameObject.GetComponent<Renderer>().material = mat7;
                break;
            case 8:
                gameObject.GetComponent<Renderer>().material = mat8;
                break;
            default:
                gameObject.GetComponent<Renderer>().material = mat9;
                break;
        }
    }

}
