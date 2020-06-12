using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class WinControl : MonoBehaviour {
	//获取文本
	public TextMesh Text;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	private void OnTriggerEnter(Collider other)
	{
		if(other.tag == "Player")
		{
			Text.text = "Victory";
		}
	}

	public void LoadScence(string Scencename)
	{
		SceneManager.LoadScene(Scencename);

	}
}
