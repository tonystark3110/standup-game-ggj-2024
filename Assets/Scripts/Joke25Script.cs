using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class Joke25Script : MonoBehaviour, JokeInterface
{
    public string ButtonText { get; private set; } //required

    public int OccurrenceWeight { get; private set; } //required

    public UnityEvent onJokeStarted { get; private set; } //required

    public UnityEvent onJokeCompleted { get; private set; } //required

    public AudioClip voicePrompt;

    //You can add any number of fields to this as needed.

    public Joke25Script()
    {
        ButtonText = "I applied to 150 co-ops this semester"; //put the text for the prompt button here
        OccurrenceWeight = 0; //customize the rarity of the joke occurred (less means rarer)

        onJokeStarted = new UnityEvent();
        onJokeCompleted = new UnityEvent();
    }

    //function that will run when the button for the joke is clicked
    public void run()
    {
        onJokeStarted.Invoke(); //required - this method should be the first method in run()
        StartCoroutine(Joke25Sequence());
    }

    IEnumerator Joke25Sequence()
    {
        Debug.Log("tell the joke");

        yield return StartCoroutine(TellJoke25());

        Debug.Log("Joke 25 is completed");
    }

    IEnumerator TellJoke25()
    {
        GameObject audioLocation = new GameObject("AudioObject");
        audioLocation.transform.position = Camera.main.transform.position;
        AudioSource audioSource = audioLocation.AddComponent<AudioSource>();
        audioSource.clip = voicePrompt;
        audioSource.Play();
        Destroy(audioLocation, voicePrompt.length);

        yield return null;

        Debug.Log("Animation completed");

        onJokeCompleted.Invoke(); //required - this method should be called at the of the joke, after
    }
}
