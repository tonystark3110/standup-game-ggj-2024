using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public interface JokeInterface
{
    string ButtonText { get; }

    public int OccurrenceWeight { get; }

    public abstract void run();
}
