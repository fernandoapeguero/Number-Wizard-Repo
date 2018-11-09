using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class NumberWizard : MonoBehaviour {

    [SerializeField] int max;
    [SerializeField] int min;
    int guess;
    [SerializeField] TextMeshProUGUI textContainerGuess;


	// Use this for initialization
	void Start ()
    {
        StarGame();
	}

    void StarGame() {
       
        Guessed();
        
    }
	
	// Update is called once per frame

    public void OnPressHigher() {
        if (guess + 1 <= max) {
            min = guess + 1;
            Guessed();
        }

    }

    public void OnPressLower() {
        if (guess - 1 >= min) {

            max = guess - 1;
            Guessed();
        }
        
    }

    void Guessed() {
            guess = Random.Range(min , max + 1) ;
            textContainerGuess.text = guess.ToString();

    }
}
