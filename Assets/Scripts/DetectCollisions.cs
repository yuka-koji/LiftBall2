using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("CollisionCube");
    }

    // Update is called once per frame
    void Update()
    {
        // if (OVRInput.GetUp(OVRInput.Button.Two)) 
        // {
        //     // OVRDebugConsole.Log("Bボタンが押されました");
        //     cube.GetComponent<Renderer>().material.color = Color.red;
        // }
    }

    // 物体同士がぶつかった時に呼ばれる関数
    private void OnCollisionEnter(Collision collision)
    {
        // if (collision.gameObject.CompareTag("Glove"))
        // {
            if (cube.GetComponent<Renderer>().material.color == Color.red){
                cube.GetComponent<Renderer>().material.color = Color.blue;
            } else {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }
            // Destroy(collision.gameObject);
        // }
    }
}
