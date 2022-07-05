using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonBehaviour : MonoBehaviour {

	//int n = 2;
	public int code;
	public List<int> seq = new List<int>() {1};
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}

	public void Acerto(){
		//aumento de variável
		InvokeRepeating("Random_Color", 3f, 2f);
		Debug.Log(code);
		seq.Add(code);

	}

	void Random_Color(){
		code = Random.Range(1, 4);
	}
}

