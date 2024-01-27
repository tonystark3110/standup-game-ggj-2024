using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;


public class JokeButtonManager : MonoBehaviour
{

    public JokeInterface[] jokes;

    //for test

    
    [SerializeField]
    public GameObject jokeTest;

    public Button buttonPrefab;

    private GameObject[] jokeObjects;

    // Start is called before the first frame update
    void Start()
    {

        jokeObjects = GameObject.FindGameObjectsWithTag("Joke");

        returnButtonInstance(jokeObjects[0]);

        /*
        JokeInterface joke1 = jokeTest.GetComponent<JokeInterface>();

        Debug.Log("joke 1: " + joke1);

        Button myButtonInstance = Instantiate(buttonPrefab, transform);

        Debug.Log("button text: " + joke1.ButtonText);
        Debug.Log("text child: " + myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text);

        myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text = joke1.ButtonText;

        myButtonInstance.onClick.AddListener(joke1.run);*/


        //myButtonInstance.gameObject.AddComponent<JokeInterfaceComponent>().SetJoke(joke1);

        //myButtonInstance.onClick.AddListener(gameObject.GetComponent<JokeInterfaceComponent>().RunJoke);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    private Button returnButtonInstance(GameObject jokeObject)
    {
        JokeInterface joke = jokeObject.GetComponent<JokeInterface>();

        Debug.Log("joke 1: " + joke);

        Button myButtonInstance = Instantiate(buttonPrefab, transform);

        Debug.Log("button text: " + joke.ButtonText);
        Debug.Log("text child: " + myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text);

        myButtonInstance.GetComponentInChildren<TextMeshProUGUI>().text = joke.ButtonText;

        myButtonInstance.onClick.AddListener(joke.run);

        return myButtonInstance;
    }
}

/*
public class JokeInterfaceComponent : MonoBehaviour
{
    private JokeInterface jokeInstance;

    public void SetJoke(JokeInterface other)
    {
        this.jokeInstance = other;
    }

    public void RunJoke()
    {
        if (jokeInstance != null)
        {
            jokeInstance.run();
        }
    }
}*/
