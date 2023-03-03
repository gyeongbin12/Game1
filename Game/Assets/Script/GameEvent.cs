using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameEvent : Singleton<GameEvent>
{

    public event Action<int> onDoorEnter;
    public event Action<int> onDoorExit;

    public void DoorTriggerEnter(int enterCount)
    {
        if (onDoorEnter != null)
        {
            onDoorEnter(enterCount);
        }
    }

    public void DoorTriggerExit(int exitCount)
    {
        if (onDoorExit != null)
        {
            onDoorExit(exitCount);
        }
    }
}
