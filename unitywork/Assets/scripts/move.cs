using UnityEngine;
using System.Collections;

public class move : MonoBehaviour {
	public GameObject cube;
	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		cube.transform.Translate (new Vector3(1,1,1));
	}
}
