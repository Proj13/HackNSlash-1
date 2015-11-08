using UnityEngine;
using System.Collections;

public class CountDown : MonoBehaviour {

	float timeRemaining = 60.0f;
	
	void Update () {
		timeRemaining -= Time.deltaTime;
	}
	
	void OnGUI(){
		if(timeRemaining > 0){
			GUI.Label(new Rect(Screen.width/2.06f, Screen.height/72f, 200, 100), 
			          "Time Remaining : "+timeRemaining);
		}
		else{
			GUI.Label(new Rect(600, 100, 200, 100), "Time's Up");
		}
	}
}
