using UnityEngine;
using System.Collections;

public class Shadow : MonoBehaviour {

	public RenderTexture t;	
	
	void Update () {
		renderer.material.mainTexture = t;
	}
	
	void OnGUI()
	{
		GUI.DrawTexture(new Rect(0,0,100,100),t);
	}
}
