using System;
using Sirenix.OdinInspector;

[Serializable]
public class FlutePatternItem {
    [SuffixLabel("$TimeToMinutes"), LabelWidth(35)]
    public int Time;

    [HideLabel] public Side ActionSide;
    [HideLabel] public FlutePatternEnum Action;

    [ToggleLeft] public bool isCombo;
    [ShowIf("isCombo"), HideLabel] public FlutePatternEnum Combo;
    
    public string TimeToMinutes() {
        TimeSpan timeSpan = TimeSpan.FromMilliseconds(Time);
        string time = string.Format("{0:D1}m:{1:D2}s:{2:D3}ms",
            timeSpan.Minutes,
            timeSpan.Seconds,
            timeSpan.Milliseconds);

        return time;
    }
}

[EnumToggleButtons]
public enum Side {
    Left,
    Right
}

[EnumToggleButtons]
public enum FlutePatternEnum {
    A,
    B,
    C,
    D
}