// Enemy Rotation
// EnemyRatation.cs
// >>> I AM NOT THE AUTHER... FROM UNITY STORE
// 12.2.18

// Libraries
using UnityEngine;
using UnityEngine.UI;
using System;
using System.Collections;
using System.Text;

// Able to store and organize
[Serializable]
// Public Class TypeOutScript MonoBehaviour
public class TypeOutScript : MonoBehaviour {

// Public Variables
    // Bool place setter for true for effect being on
	public bool On = true;
    // To reset using editor (I AM NOT BUT DID NOT KNOW HOW TO CHAnGE WITHOUT DAMAGE TO CODE)
	public bool reset = false;
    // Final text to compare to for loops
	public String FinalText;
    // int variable place holder i
    public int i;
    // Time set for defualt typing time
    public float TotalTypeTime = -1f;
    // For typing rate
	public float TypeRate;

// Private Variables
    // For ability to pull random character for effect
	public string RandomCharactor;
    // The amount of time a random character will display
	public float RandomCharacterChangeRate = 0.1f;
    // Display time of random character
	private float RandomCharacterTime;
    // List time a random character will display
    private float LastTime;


	// SUMMARY: This function gets a random character
	private string RandomChar()
	{
		byte value = (byte)UnityEngine.Random.Range(41f,128f);

		string c = Encoding.ASCII.GetString(new byte[]{value});

		return c;

	}


    // SUMMARY: This allows the player to turn on and off the typing effect
	public void Skip()
	{
		GetComponent<Text>().text = FinalText;
		On = false;
	}
	


	// Update is called once per frame
	void OnGUI() 
	{
        // SUMMARY: Allows you to use slider to change the type time
		if (TotalTypeTime != -1f)
		{
			TypeRate = TotalTypeTime/(float)FinalText.Length;
		}

        // If effect is turned on then ...
		if (On == true)
		{

            // SUMMARY: This allows the character to type out and while typing out display a random character before diplaying the correct character
			if (Time.time - RandomCharacterTime >= RandomCharacterChangeRate)
			{
				RandomCharactor = RandomChar();
				RandomCharacterTime = Time.time;
            }

			try
			{
				GetComponent<Text>().text = FinalText.Substring(0,i) + RandomCharactor;
			}
			catch(ArgumentOutOfRangeException)
			{
				On = false;
			}

			if (Time.time- LastTime >= TypeRate)
			{
				i++;
				LastTime = Time.time;
			}

			bool isChar = false;

            // SUMMARY: Actually find and display the correct character
			while (isChar == false)
			{
				if ((i + 1) < FinalText.Length)
				{
					if (FinalText.Substring(i,1) == " ")
					{
						i++;
					}
					else
					{
						isChar = true;
					}
				}
				else
				{
					isChar = true;
				}
			}

            // SUmMARY: If the characters in the text are equal to the effects characters the trun of the effect and diplay the words
			if (GetComponent<Text>().text.Length == FinalText.Length + 1)
			{
				RandomCharactor = RandomChar();
				GetComponent<Text>().text = FinalText;
				On = false;
			}

		}

        // SUMMARY: For reset for each new scene
		if (reset == true )
		{
			GetComponent<Text>().text = "";
			i = 0;
			reset = false;
		}
	}
}
