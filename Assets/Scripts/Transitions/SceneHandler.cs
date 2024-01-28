using System;
using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public class SceneHandler : MonoBehaviour
{
    [SerializeField]
    private GameObject transitionerPrefab;
    private static SceneHandler instance;
    // Start is called before the first frame update
    void Start()
    {
        transitionerPrefab = Instantiate(transitionerPrefab);
        instance = this;
    }
    protected void Transition(int index)
    {
        StartCoroutine(_Transition(index));
    }
    protected void Transition(string name, float time)
    {
        StartCoroutine(_Transition(name, time));
    }
    protected IEnumerator _Transition(string name, float time)
    {
        
        yield return new WaitForSeconds(time-1);
        transitionerPrefab.GetComponentInChildren<Animator>().SetTrigger("Exit");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(name);
    }
    private IEnumerator _Transition(int index)
    {
        transitionerPrefab.GetComponentInChildren<Animator>().SetTrigger("Exit");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }
    private IEnumerator _Transition(string index)
    {
        transitionerPrefab.GetComponentInChildren<Animator>().SetTrigger("Exit");
        yield return new WaitForSeconds(1);
        SceneManager.LoadScene(index);
    }

    protected void Transition(string sceneName)
    {
        StartCoroutine(_Transition(sceneName));
    }

    public static void TransitionTo(int sceneIndex)
    {
        instance.Transition(sceneIndex);
    }
    public static void TransitionTo(string  sceneName)
    {
        instance.Transition(sceneName);
    }

    public static void TransitionTo(string sceneName, float time)
    {
        instance.Transition(sceneName, time);
    }
}
