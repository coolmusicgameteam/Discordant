using System;
using System.Collections;
using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

public class Pattern : ScriptableObject {
    [SuffixLabel("$TimeToMinutes")] public int Length;

    public string TimeToMinutes() {
        TimeSpan timeSpan = TimeSpan.FromMilliseconds(Length);
        string time = string.Format("{0:D1}m:{1:D2}s:{2:D3}ms",
            timeSpan.Minutes,
            timeSpan.Seconds,
            timeSpan.Milliseconds);

        return time;
    }
}