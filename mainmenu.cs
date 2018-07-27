using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class mainmenu : MonoBehaviour {

	public void ChangeScene(string prototype1)
	{
		Application.LoadLevel (prototype1);
	}

}