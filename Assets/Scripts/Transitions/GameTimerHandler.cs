using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameTimerHandler : MonoBehaviour
{
    [SerializeField]
    [Tooltip("In seconds")]
    private float timeUntilTransition = 60;
    [SerializeField]
    private string winScene;
    
    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(WaitToExit());
    }

    IEnumerator WaitToExit()
    {
        yield return new WaitForSeconds(timeUntilTransition);
        SceneHandler.TransitionTo(winScene);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
