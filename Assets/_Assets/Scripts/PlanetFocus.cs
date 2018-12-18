using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PlanetFocus : MonoBehaviour {
    public string PlanetLevel;

	// Use this for initialization
	public void Focus()
    {
        Debug.Log("Focusing", this);
        StartCoroutine(RotateToMe());
    }

    IEnumerator RotateToMe()
    {
        var targetPosition = this.transform.position + 20f * Vector3.up;

        var targetRotation = Quaternion.LookRotation(
            this.transform.position - targetPosition,
            Vector3.up
        );

        var startTime = Time.time;
        while (Time.time < startTime + 2)
        {
            Camera.main.transform.position = Vector3.Lerp(
                Camera.main.transform.position,
                targetPosition,
                0.1f
            );

            Camera.main.transform.rotation = Quaternion.Slerp(
                Camera.main.transform.rotation,
                targetRotation,
                0.1f
            );

            yield return null;
        }

        Application.LoadLevel(PlanetLevel);
    }
}
