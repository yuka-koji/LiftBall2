using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BallMachineScript : MonoBehaviour
{

    public GameObject ballPrefab;
    // public float speed;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        // Bボタンが押されたらボールを発射する
        if (OVRInput.GetUp(OVRInput.Button.Two)) 
        {
            // Instantiate(ball, transform.position, transform.rotation);
            GameObject ball =  (GameObject)Instantiate(ballPrefab, transform.position, Quaternion.identity);
            Rigidbody ballRigidbody = ball.GetComponent<Rigidbody>();

            // 力を加える方向
			// Vector3 forceDirection = new Vector3(Random.Range(-2.0f, 2.0f), Random.Range(0.1f, 2.0f), Random.Range(0.1f, 3.0f));
			Vector3 forceDirection = new Vector3(0f, 0.2493f, 1.0f);

            // 加える力の大きさ
            float forceMagnitude = 1.0f;
			// float forceMagnitude = Random.Range(1.5f, 6.0f);

            // 速度　81.2mph→36.3m/s
            // float speed = Random.Range(1.0f, 2.0f);
            float speed = 36.3f;

			// 向きと力の計算
			Vector3 force = forceMagnitude * forceDirection * speed;

			// 力を加えるメソッド
			ballRigidbody.AddForce(force, ForceMode.Impulse);
            
        }
    }
}
