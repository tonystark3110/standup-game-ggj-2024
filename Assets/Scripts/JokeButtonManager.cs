using System.Collections;
using System;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class JokeButtonManager : MonoBehaviour
{

    public JokeInterface[] jokes;

    public AnimationClip[] animations;

    //for test

    
    [SerializeField]
    public GameObject jokeTest;

    public Button buttonPrefab;

    public int numJokesPerRound = 5;

    private GameObject[] jokeObjects;

    private List<int> alreadyPickedIdx;

    // Start is called before the first frame update
    void Start()
    {

        alreadyPickedIdx = new List<int>();

        //In order for this code to recognize and process a joke, the joke script must be
        //located within an object that is tagged "Joke"
        jokeObjects = GameObject.FindGameObjectsWithTag("Joke");


        //creates the appropriate number of buttons and animates them.
        for (int i = 0; i < numJokesPerRound; i++)
        {
            Button jokeButton = createJokeButton(pickRandomJoke());

            Animator buttonAnimator = jokeButton.GetComponent<Animator>();

            /*
            int randomIndex = UnityEngine.Random.Range(0, animations.Length);

            AnimationClip clip = animations[randomIndex];

            buttonAnimator.Play(clip.name);*/
        }


    }

    /**
     * Returns a random joke object from the list of jokes. If all jokes are used up, it will reuse a joke.
     */
    private GameObject pickRandomJoke()
    {
        System.Random random = new System.Random();

        int randomNumber = random.Next(0, jokeObjects.Length);

        //if all jokes have been used up, clear the already picked list
        if (alreadyPickedIdx.Count >= jokeObjects.Length)
        {
            alreadyPickedIdx.Clear();
        }
        //while the joke picked has already been used, pick again
        while (alreadyPickedIdx.Contains(randomNumber))
        {
            randomNumber = random.Next(0, jokeObjects.Length);
        }

        //add the current joke to the list of jokes already picked
        alreadyPickedIdx.Add(randomNumber);
        return jokeObjects[randomNumber];
    }

    /**
     * Returns a Button object created from the information stored in the given jokeObject
     */
    private Button createJokeButton(GameObject jokeObject)
    {

        //get the JokeInterface script component from the given joke game object
        JokeInterface joke = jokeObject.GetComponent<JokeInterface>();

        Debug.Log("joke: " + joke);

        //instantiate the button
        Button myButtonInstance = Instantiate(buttonPrefab, transform);

        Debug.Log("button text: " + joke.ButtonText);
        //Debug.Log("text child: " + myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text);

        //change the text of the button
        myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text = joke.ButtonText;

        //add an animator component to the button
        myButtonInstance.gameObject.AddComponent<Animator>();

        //add the run function from the joke object as a listener to the button click event
        myButtonInstance.onClick.AddListener(joke.run);

        return myButtonInstance;
    }

    // Update is called once per frame
    void Update()
    {

    }

}