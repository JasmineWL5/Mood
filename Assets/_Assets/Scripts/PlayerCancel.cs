using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlayerCancel : MonoBehaviour {

	public void Update()
    {
        if (Input.GetKeyDown(KeyCode.Escape))
        {
            Application.LoadLevel("MainScene");
        }
    }
}
