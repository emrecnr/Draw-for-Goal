using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class LinePool : GenericPool<LineRenderer>
{
    public static LinePool Instance { get; private set; }
    protected override void SingletonObject()
    {
        if (Instance == null)
        {
            Instance = this;
            DontDestroyOnLoad(this.gameObject);
        }
        else
            Destroy(this.gameObject);

    }
}


