using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Change_Color : MonoBehaviour {

	public Text Color_text;
	public int code;
	public float wait_time = 3f, rate = 2f;
	[SerializeField]
	private ButtonBehaviour scriptSequencia;

	void Start(){
		InvokeRepeating("Random_Color", wait_time, rate);
		//Debug.Log("programa rodando");
	}

	void Update(){
		/*if(code%2 == 0){
			Color_text.text = "azul".ToString(); 
		} else{
			Color_text.text = "Verde".ToString();
		}*/
		
		if(scriptSequencia.seq[0] == 1)
			Color_text.text = "Azul".ToString();
		else if(scriptSequencia.seq[0] == 2)
			Color_text.text = "Verde".ToString();
		else if(scriptSequencia.seq[0] == 3)
			Color_text.text = "Vermelho".ToString();
		else if(scriptSequencia.seq[0] == 4)
			Color_text.text = "Amarelo".ToString();
	}

	void Random_Color(){
		code = Random.Range(1, 6);
	}
}