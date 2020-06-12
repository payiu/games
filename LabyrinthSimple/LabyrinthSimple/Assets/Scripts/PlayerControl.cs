using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerControl : MonoBehaviour {
	//获取效果：碰撞
	public GameObject hitPer;
	//爆炸效果
	public GameObject bombPer;
	//定义血量
	public int hp = 3;


	private Rigidbody rBody;


	// Use this for initialization
	//最开始调用，只调用一次
	void Start () {
		rBody = GetComponent<Rigidbody>();
		
	}
	
	// Update is called once per frame
	//循环调用，每一帧调用一次
	void Update () {

		//获取水平轴
		float horizontal = Input.GetAxis("Horizontal");

		//获取垂直轴
		float vertical = Input.GetAxis("Vertical");

		//获取方向
		Vector3 dir = new Vector3(horizontal, 0, vertical);
		//判断方向
		if(dir != Vector3.zero)
		{
			//移动
			rBody.velocity = dir * 2;
		}

		
	}

	//只要碰到碰撞体，就会调用
	private void OnCollisionEnter(Collision collision)
	{
		//如果碰到的是墙
		if (collision.collider.tag == "Wall")
		{
			hp--;
			if(hp <= 0)
			{
				AudioManager.Instance.PlayBomb();
				//死掉
				//实例化一个预设体
				Instantiate(bombPer, transform.position, Quaternion.identity);
				Destroy(gameObject);
			}
			else
			{
				//没死掉
				//实例化一个碰撞效果
				Instantiate(hitPer, collision.contacts[0].point, Quaternion.identity);
			}
		}
	}
}
