using UnityEngine;
using System.Collections;

public class backbtn : MonoBehaviour {

	public static UIImageButton button;
	
	void Awake ()   
	{
		button = GetComponent<UIImageButton>();
		NGUITools.SetActive(button.gameObject, false);
	}
	
	// Use this for initialization
	void Start () {

	}
	
	// Update is called once per frame
	void Update () {
	
	}
}
