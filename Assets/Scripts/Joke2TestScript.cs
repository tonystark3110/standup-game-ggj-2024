using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Joke2TestScript : MonoBehaviour, JokeInterface
{
    public string ButtonText { get; private set; }

    public int OccurrenceWeight { get; private set; }

    public UnityEvent onJokeStarted { get; private set; }

    public UnityEvent onJokeCompleted { get; private set; }


    public GameObject thing;

    public Joke2TestScript()
    {
        ButtonText = "lol";
        OccurrenceWeight = 3;

        onJokeStarted = new UnityEvent();
        onJokeCompleted = new UnityEvent();
    }


    public void run()
    {

        onJokeStarted.Invoke();

        Debug.Log("Joke2 is in fact funnny");

        StartCoroutine(Joke2Sequence());

        
    }

    IEnumerator Joke2Sequence()
    {
        Debug.Log("tell the joke");

        yield return StartCoroutine(TellJoke2());

        Debug.Log("Joke 2 is completed");
    }

    IEnumerator TellJoke2()
    {

        Vector3 startPosition = new Vector3(68.8099976f, 21.0326958f, 38.8139725f);

        Vector3 endPosition = new Vector3(-85.5100021f, -4.04212952f, -16.9272423f);


        float timeToAnimate = 1f;

        float elapsedTime = 0f;

        while (elapsedTime < timeToAnimate)
        {
            thing.transform.position = Vector3.Lerp(startPosition, endPosition, elapsedTime / timeToAnimate);

            elapsedTime += Time.deltaTime;

            yield return null;
        }

        thing.transform.position = endPosition;

        Debug.Log("Animation completed");

        onJokeCompleted.Invoke();
    }



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
