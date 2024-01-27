using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[System.Serializable]
public class Joke1TestScript : MonoBehaviour, JokeInterface
{

    // = "this joke is funny";
    // int occurrenceWeight
    // public string ButtonText { get => text; private set => text = value; }

    public string ButtonText { get; private set; }

    public int OccurrenceWeight { get; private set; }

    public Joke1TestScript()
    {
        ButtonText = "blah";
        int OccurrenceWeight = 5;

    }

    public void run()
    {
        //write script for the joke here

        Debug.Log("Joke 1 test is NOT funny");

        
        
    }

}
