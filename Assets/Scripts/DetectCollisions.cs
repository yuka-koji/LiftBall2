using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DetectCollisions : MonoBehaviour
{

    GameObject cube;
    GameObject ballMachine;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("CollisionCube");
        ballMachine = GameObject.Find("GameObject");
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

    private void OnCollisionEnter(Collision collision)
    // private void OnCollisionStay(Collision collision)
    {
        if (collision.gameObject.CompareTag("Glove"))
        {
            // ここでPrefabShot.csを無効にしたらいいはず？
            // this.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z-2.0f);
            // this.transform.position = new Vector3(collision.transform.position.x, collision.transform.position.y, collision.transform.position.z);
            // this.GetComponent<PrefabsShot>().enabled = false;
            // ballMachine.GetComponent<PrefabsShot>().enabled = false;

            this.transform.position = new Vector3(cube.transform.position.x, cube.transform.position.y, cube.transform.position.z);

            if (cube.GetComponent<Renderer>().material.color == Color.red){
                cube.GetComponent<Renderer>().material.color = Color.blue;
            } else {
                cube.GetComponent<Renderer>().material.color = Color.red;
            }
            
        }
            
    }

    // 物体同士がぶつかった時に呼ばれる関数
    // private void OnCollisionEnter(Collision collision)
    // {
    //     if (collision.gameObject.CompareTag("Glove"))
    //     {
    //                     if (cube.GetComponent<Renderer>().material.color == Color.red){
    //             cube.GetComponent<Renderer>().material.color = Color.blue;
    //         } else {
    //             cube.GetComponent<Renderer>().material.color = Color.red;
    //         }
    //         // Destroy(collision.gameObject);
    //     }
    // }
}
