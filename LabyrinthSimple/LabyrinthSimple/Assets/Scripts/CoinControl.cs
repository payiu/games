using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CoinControl : MonoBehaviour {

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

		//控制金币旋转
		transform.Rotate(Vector3.forward * 90 * Time.deltaTime);
	}

	//触发器调用
	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			AudioManager.Instance.PlayCoin();
			Destroy(gameObject);
		}
	}
}
