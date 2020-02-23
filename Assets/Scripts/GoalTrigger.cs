using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GoalTrigger : MonoBehaviour
{
	public GameObject LapCompleteTrig;
	public GameObject LapStartTrig;

	void OnTriggerEnter() {
		LapCompleteTrig.SetActive(true);
		LapStartTrig.SetActive(false);
	}
}
