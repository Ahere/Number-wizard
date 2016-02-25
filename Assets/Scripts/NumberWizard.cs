using UnityEngine;
using System.Collections;
using UnityEngine.UI;

public class NumberWizard : MonoBehaviour {
	// Use this for initialization
	

	public Text guessText; 

	int max = 1000 ;
	int min = 1 ;
	int guess ; 

	
	void Start ()
	{
		
     StartGame();
	}

  
	
	// Update is called once per frame
   

  
    public void GuessHigher()
 		{
        	min = guess;
        	NextGuess();
		}
	public void GuessLower()
		{  
            max = guess;
            NextGuess();
      	}
	public void GuessCorrect()
		{  
            
            StartGame();
      	}


 
 	void StartGame ()
    	{  
	       


	       max += 1;
      	   NextGuess();
          
		    //print("===================================");
			//print("Welcome to NumberWizard");
		    //print("Pick a number in your head but don't tell me");

				
			//print("the higest number you can pick is " + max + " and the lowest nuumber you can pick is " + min);
			    
		    //print("Is the number higher or lower than "+ guess +" ?" );
			//print("Press Up = HIGHER, down arrow = LOWER and Enter = EQUAL TO");
        
    }


  void NextGuess ()
   {

        //guess = (min + max)/2 ;
        guess=Random.Range(min,max);
        //guessText.text = guess.ToString();
       ///print ("Higher or lower than "  + guess);
       // print("Press Up = HIGHER, down arrow = LOWER and Enter = EQUAL TO");
        guessText.text = guess.ToString();
   }




}
