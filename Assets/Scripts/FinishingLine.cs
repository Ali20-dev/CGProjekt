using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class FinishingLine : MonoBehaviour
{
	public GameObject Popup, Panel, LapCompleteTrig, Rundentimer, oldMinDisplay, newMinDisplay, oldSecDisplay, newSecDisplay, oldMilliDisplay, newMilliDisplay;

	void OnTriggerEnter() {
		newMinDisplay.GetComponent<Text> ().text = oldMinDisplay.GetComponent<Text> ().text;
		newSecDisplay.GetComponent<Text> ().text = oldSecDisplay.GetComponent<Text> ().text;
		newMilliDisplay.GetComponent<Text> ().text = oldMilliDisplay.GetComponent<Text> ().text;
		Popup.SetActive(true);
		Panel.SetActive(false);
		LapCompleteTrig.SetActive(false);
		Rundentimer.SetActive(false);
	}
}
