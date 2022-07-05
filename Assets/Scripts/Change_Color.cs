using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Color : MonoBehaviour {

	public Text Color_text;
	public int code;
	public float wait_time = 3f, rate = 2f;

	void Start(){
		InvokeRepeating("Random_Color", wait_time, rate);
	}

	void Update(){
		if(code%2 == 0){
			Color_text.text = "azul".ToString(); 
		} else{
			Color_text.text = "Verde".ToString();
		}		
	}

	void Random_Color(){
		code = Random.Range(1, 6);
	}
}