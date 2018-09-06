using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class GuessTheNumber : MonoBehaviour {

    public InputField input;
    public Text infoText;

    private int guessNumber;
    private int usersGuess;

	// Use this for initialization
	void Start () {
        guessNumber = Random.Range(0, 100);
	}
	
    public void CheckGuess() {
        usersGuess = int.Parse(input.text);

        if (usersGuess == guessNumber){
            infoText.text = "You Won, You Are A Number Wizard!";
        } else if (usersGuess > guessNumber) {
            infoText.text = "Your guess is too BIG, try a smaller number.";
        } else if (usersGuess < guessNumber) {
            infoText.text = "Your guess is too SMALL, try a bigger number.";
        } else {
            infoText.text = "Please Enter Your Guess To Play";
        }
    }
}
