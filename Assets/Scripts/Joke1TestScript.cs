using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Joke1TestScript : MonoBehaviour, JokeInterface
{

    // = "this joke is funny";
    // int occurrenceWeight
    // public string ButtonText { get => text; private set => text = value; }

    public string ButtonText { get; private set; }

    public int OccurrenceWeight { get; private set; }

    public UnityEvent onJokeStarted { get; private set; }
    public UnityEvent onJokeCompleted { get; private set; }

    public Joke1TestScript()
    {
        ButtonText = "blah";
        int OccurrenceWeight = 5;

        onJokeStarted = new UnityEvent();
        onJokeCompleted = new UnityEvent();

    }

    public void run()
    {

        onJokeStarted.Invoke();

        //write script for the joke here

        Debug.Log("Joke 1 test is NOT funny");

        onJokeCompleted.Invoke();
    }

}
