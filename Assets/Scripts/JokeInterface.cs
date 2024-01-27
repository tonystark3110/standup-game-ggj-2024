using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public interface JokeInterface
{
    string ButtonText { get; }

    public int OccurrenceWeight { get; }

    public UnityEvent onJokeStarted { get; }
    public UnityEvent onJokeCompleted { get; }

    public abstract void run();
}
