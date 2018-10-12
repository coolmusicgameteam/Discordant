using System;
using Sirenix.OdinInspector;

[Serializable]
public class BossPatternItem {
    [HorizontalGroup("Split", 0.3f), LabelWidth(35)]
    public int Time;
    
    [EnumToggleButtons, HorizontalGroup("Split"), HideLabel]
    public BossPatternEnum Action;
    
    public string TimeToMinutes() {
        TimeSpan timeSpan = TimeSpan.FromMilliseconds(Time);
        string time = string.Format("{0:D1}m:{1:D2}s:{2:D3}ms",
            timeSpan.Minutes,
            timeSpan.Seconds,
            timeSpan.Milliseconds);

        return time;
    }
}

public enum BossPatternEnum {
    Up,
    Down,
    Left,
    Right
}