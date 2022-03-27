using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallShot : MonoBehaviour
{
    public GameObject ballPrefab;
    public float speed;

    // Start is called before the first frame update
    void Start()
    {
        // Bボタンが押されたらボールを発射する
        if (OVRInput.GetUp(OVRInput.Button.Two)) 
        {
            GameObject ball =  (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
            ballRigidbody.AddForce(transform.forward * speed);
        }
    }

    // Update is called once per frame
    void Update()
    {

        // // Bボタンが押されたらボールを発射する
        // if (OVRInput.GetUp(OVRInput.Button.Two)) 
        // {
        //     GameObject ball =  (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
        //     Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();
        //     ballRigidbody.AddForce(transform.forward * speed);
        // }

    }

    
}
