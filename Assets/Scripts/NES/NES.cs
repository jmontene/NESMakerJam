using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class NES : MonoBehaviour {
	public static NES _instance;
	public static NES instance{
		get{
			if (_instance == null) {
				_instance = GameObject.FindObjectOfType<NES> ();
				if (_instance == null) {
					GameObject obj = new GameObject ("NES");
					_instance = obj.AddComponent<NES> ();
				}
			}
			return _instance;
		}
	}

	[Header("Palettes")]
	public PaletteSet backgroundPalettes;
	public PaletteSet spritePalettes;

	List<NESObject> objects;

	void Awake(){
		if (_instance == null) {
			_instance = this;
			DontDestroyOnLoad (gameObject);
		} else {
			Destroy (gameObject);
		}
		objects = new List<NESObject> (GameObject.FindObjectsOfType<NESObject>());
		objects.ForEach ((obj) => obj.Init ());
	}

	// Use this for initialization
	void Start () {
	}
	
	// Update is called once per frame
	void Update () {
		objects.ForEach ((obj) => obj.Refresh(Time.deltaTime));
	}
}
