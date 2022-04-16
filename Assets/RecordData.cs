using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class RecordData : MonoBehaviour {

	// Use this for initialization
	public FileWriter FW;
	public string Data;
	public bool Flag;
	int count = 0;
	public int CountClock = 30;
	void Start () {
		
	}
	
	// Update is called once per frame
	void FixedUpdate () {
		if (count <= 0) {
			Data = gameObject.transform.position.x.ToString();
			Data += ","+gameObject.transform.position.y.ToString();
			Data += ","+gameObject.transform.position.z.ToString();
			Data += ","+Flag.ToString();
			FW.WriteFile(Data);//Write string Data as a line of data
			count = CountClock;
		} else {
			count -= 1;
		}
	}
}
