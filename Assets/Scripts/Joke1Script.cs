using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[System.Serializable]
public class Joke1Script : MonoBehaviour, JokeInterface
{

    // = "this joke is funny";
    // int occurrenceWeight
    // public string ButtonText { get => text; private set => text = value; }
    public string ButtonText { get; private set; }

    public int OccurrenceWeight { get; private set; }

    public UnityEvent onJokeStarted { get; private set; }

    public UnityEvent onJokeCompleted { get; private set; }


    public Joke1Script()
    {
        ButtonText = "E";
        OccurrenceWeight = 5;

        onJokeStarted = new UnityEvent();
        onJokeCompleted = new UnityEvent();
    }


    public void run()
    {

        onJokeStarted.Invoke();

        Debug.Log("Joke1 is NOT funnny");

        StartCoroutine(Joke1Sequence());

    }

    IEnumerator Joke1Sequence()
    {
        Debug.Log("tell the joke");

        yield return StartCoroutine(TellJoke1());

        Debug.Log("Joke 1 is completed");
    }

    IEnumerator TellJoke1()
    {
        //should bass boost now

        float timeToAnimate = 1f;

        float elapsedTime = 0f;

        while (elapsedTime < timeToAnimate)
        {
            elapsedTime += Time.deltaTime;

            yield return null;
        }

        Debug.Log("Animation completed");

        onJokeCompleted.Invoke();

    }
}
