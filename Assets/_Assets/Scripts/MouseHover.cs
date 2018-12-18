using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class MouseHover : MonoBehaviour {
    private Color startcolor;

	// Use this for initialization
	void Start () {
		
	}

    private void OnMouseEnter()
    {
        //startcolor = renderer.material.color;
        //renderer.material.color = Color.yellow;
    }

    private void OnMouseExit()
    {
        //renderer.material.color = startcolor;
    }
    // Update is called once per frame
    void Update () {
		
	}
}
