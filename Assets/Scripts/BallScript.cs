using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallScript : MonoBehaviour
{

    // public float speed;

    GameObject cube;

    // Start is called before the first frame update
    void Start()
    {
        cube = GameObject.Find("CollisionCube");
    }

    // Update is called once per frame
    void Update()
    {
        // Rigidbody ballRigidbody = this.GetComponent<Rigidbody>();

        // // 力を加える方向
        // // Vector3 forceDirection = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(0.1f, 2.0f), Random.Range(0.1f, 3.0f));
        // Vector3 forceDirection = new Vector3(0f, 0.2493f, 1.0f);

        // // 加える力の大きさ
        // float forceMagnitude = 1.0f;
        // // float forceMagnitude = Random.Range(1.5f, 6.0f);

        // // 速度　81.2mph→36.3m/s
        // // float speed = Random.Range(1.0f, 2.0f);
        // float speed = 36.3f;

        // // 向きと力の計算
        // Vector3 force = forceMagnitude * forceDirection * speed;

        // // 力を加えるメソッド
        // ballRigidbody.AddForce(force, ForceMode.Impulse);
    }

    private void OnCollisionEnter(Collision collision)
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
}
