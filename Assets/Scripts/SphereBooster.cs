using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SphereBooster : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (OVRInput.GetUp(OVRInput.Button.Two)) 
        {
            // ボールを飛ばす処理をStart()からここに移動させる

			// 力を加える方向
			Vector3 forceDirection = new Vector3(1.0f, 1.0f, 0f);

			// 加える力の大きさ
			float forceMagnitude = 10.0f;

			// 向きと力の計算
			Vector3 force = forceMagnitude * forceDirection;

			// SphereオブジェクトのRigidbodyコンポーネントへの参照を取得
			Rigidbody rb = gameObject.GetComponent<Rigidbody>();

			// 力を加えるメソッド
			rb.AddForce(force, ForceMode.Impulse);

        }    
    }
}
