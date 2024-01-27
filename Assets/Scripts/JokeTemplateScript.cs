using UnityEngine;
using UnityEngine.Events;

//change name of JokeTemplateScript to whatever your script's name is called
//this script should inherit from JokeInterface
public class JokeTemplateScript : MonoBehaviour, JokeInterface
{
    public string ButtonText { get; private set; } //required
    
    public int OccurrenceWeight { get; private set; } //required

    public UnityEvent onJokeStarted { get; private set; } //required

    public UnityEvent onJokeCompleted { get; private set; } //required

    //You can add any number of fields to this as needed.

    public JokeTemplateScript()
    {
        ButtonText = "Text for button here"; //put the text for the prompt button here
        OccurrenceWeight = 0; //customize the rarity of the joke occurred (less means rarer)

        onJokeStarted = new UnityEvent();
        onJokeCompleted = new UnityEvent();
    }

    //function that will run when the button for the joke is clicked
    public void run()
    {
        onJokeStarted.Invoke(); //required - this method should be the first method in run()

        /*
         * Write the code for your sequence of joke events here.
         * 
         * To create a sequence of events, you can create a Coroutine that contains
         * the code for a specific step you want to run. In run(), call:
         * 
         * yield return StartCoroutine(YourCoroutine())
         * 
         * this will wait until all the code runs in the Coroutine before running the next steps.
         * 
         * Example:
         * 
         * public void run() {
         * 
         *  onJokeStarted.Invoke();
         *  
         *  yield return StartCoroutine(MyCoroutine());
         *  
         *  onJokeEnded.Invoke();
         * 
         * }
         * 
         * IEnumerator MyCoroutine {
         *   
         *   //play sound effects, animate objects, etc. here
         * }
         * 
         * You can create multiple Coroutines and chain them together to create a sequence of events
         * 
         * Example:
         * 
         * yield return StartCoroutine(Step1());
         * yield return StartCoroutine(Step2());
         * yield return StartCoroutine(Step3());
         * 
         * You can enable, disable, and animate objects in these Coroutines, 
         * as well as play sound effects among other things. 
         * 
         * If you have a specific game object that will only be used in your joke, 
         * you can add it as a child object of the joke object.
         * 
         */

        onJokeCompleted.Invoke(); //required - this method should be called at the of the joke, after
            //the joke has been said and the audience reacts (or doesn't react)
    }
}
