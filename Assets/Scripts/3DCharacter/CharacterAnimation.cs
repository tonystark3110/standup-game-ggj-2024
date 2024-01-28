using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CharacterAnimation : MonoBehaviour
{
    [SerializeField]
    private Animator anim;
    private static CharacterAnimation instance;
    public static CharacterAnimation Instance {  get { return instance; } }

    [SerializeField]
    [Tooltip("This action mapping must match the animator indexing.")]
    private ActionToIndexMapping[] actionMappings;

    private Dictionary<AnimationActions, int> indexMapping;

    // Start is called before the first frame update
    void Awake()
    {
        instance = this;

        indexMapping = new Dictionary<AnimationActions, int>();
        foreach (ActionToIndexMapping actionMappings in actionMappings)
        {
            indexMapping.Add(actionMappings.action, actionMappings.index);
        }
    }

    /// <summary>
    /// Have the character animator perform an action.
    /// </summary>
    /// <param name="action"></param>
    public void StartAct(AnimationActions action)
    {
        this.anim.SetInteger("ActionIndex", indexMapping[action]);
        this.anim.SetTrigger("Action");
    }

    public void StopAct()
    {
        this.anim.SetTrigger("Stop");
    }


    public enum AnimationActions { Talking, NoteReading, Yelling, Dissapointed};

    [System.Serializable]
    private class ActionToIndexMapping
    {
        public AnimationActions action;
        public int index;
    }
}
