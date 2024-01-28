using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TestCharacterAnimator : MonoBehaviour
{
    private CharacterAnimation animator;
    // Start is called before the first frame update
    void Start()
    {
        animator = GetComponent<CharacterAnimation>();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            animator.StartAct(CharacterAnimation.AnimationActions.Talking);
        }else if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            animator.StartAct(CharacterAnimation.AnimationActions.NoteReading);
        } else if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            animator.StartAct(CharacterAnimation.AnimationActions.Yelling);
        } else if (Input.GetKeyDown(KeyCode.Alpha4))
        {
            animator.StartAct(CharacterAnimation.AnimationActions.Dissapointed);
        } else if (Input.GetKeyDown(KeyCode.Alpha0))
        {
            animator.StopAct();
        }
    }
}
