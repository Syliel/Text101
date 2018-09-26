using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AdventureGame : MonoBehaviour {

    [SerializeField] Text textComponent;

	// foo
	// Use this for initialization
	void Start () {
		Debug.Log("Look mom, it's notepad++");
		
        textComponent.text = ("I am typing stuff!");
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
}
