using UnityEngine;
using UnityEngine.UI; // for Text
using System.Collections;

public class NumberWizard : MonoBehaviour {
	int max;
	int min;
	int guess;
	int maxGuessAllowed = 10;
	
	
	public Text text;
	public Text text2; // text variable of type Text
	
	void StartGame() {
		max = 1000;
		min = 1;
		NextGuess (); // first thing in the game change number
		
	}
	
	
	
	// Use this for initialization
	void Start () {	
		StartGame ();		
	}
	
	public void GuessHigher() {
		min = guess;
		NextGuess ();
	}
	
	public void GuessLower() {
		max = guess;
		NextGuess ();
	}
	
	
	// Does binary search
	void NextGuess() {
		guess = Random.Range(min,max + 1); // Random max exclusive
		text.text = guess.ToString(); // from number to a string
		maxGuessAllowed--;
		if (maxGuessAllowed <= 0) {
			// jump to win scene
			Application.LoadLevel("Win");
		} 
	}
}
