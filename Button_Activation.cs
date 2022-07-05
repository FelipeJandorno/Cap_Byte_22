using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Button_Activation : MonoBehaviour {

	[SerializeField]
	private ButtonBehaviour comportamentoBotao;

	void Awake(){
		comportamentoBotao = new ButtonBehaviour();
	}
	/*
	public void Button_01(){
		Debug.Log("botão 01");
	}

	public void Button_02(){
		Debug.Log("botão 02");
	}

	public void Button_03(){
		Debug.Log("botão 03");
	}

	public void Button_04(){
		Debug.Log("botão 04");
	}*/

	public void OnClick(){

		Debug.Log("clicou");
		comportamentoBotao.Acerto();
	}
}
