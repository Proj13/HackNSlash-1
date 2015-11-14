using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class DisplayScore : MonoBehaviour {

	public class countDown_v002 : MonoBehaviour {
		
		Text text;
		int victimsRemaning = GameObject.FindGameObjectsWithTag("victim").Length;
		//public GUIStyle textStyle;
		
		void Start(){
			text = GetComponent<Text> ();
			Debug.Log (victimsRemaning);
		}
		void Update () {
			victimsRemaning = GameObject.FindGameObjectsWithTag ("victim").Length;
			Debug.Log (victimsRemaning);
		}
		
		void OnGUI(){
			//textStyle.normal.textColor = Color.white;
			//textStyle.font = (Font)Resources.Load ("CHILLER");
			//textStyle.fontSize = 24;
			
			if(victimsRemaning > 0){
				text.text = "Victims Needed: " + victimsRemaning.ToString();
				//GUI.Label(new Rect(Screen.width/2.06f, Screen.height/72f, 200, 100), "Time Remaining : "+timeRemaining, textStyle);
			}
			else{
				text.text = "Get To the Exit!";
				//GUI.Label(new Rect(600, 100, 200, 100), "Time's Up");
			}
		}
	}
}