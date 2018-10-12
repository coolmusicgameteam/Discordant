using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu]
public class Section : ScriptableObject {
    [ToggleGroup("Boss")] public bool Boss;
    [ToggleGroup("Flute")] public bool Flute;
    [ToggleGroup("Lute")] public bool Lute;
    [ToggleGroup("Violin")] public bool Violin;


    [ToggleGroup("Boss"), InlineEditor] public Pattern BossPattern;
    [ToggleGroup("Flute"), InlineEditor] public Pattern FlutePattern;
    [ToggleGroup("Lute"), InlineEditor] public Pattern LutePattern;
    [ToggleGroup("Violin"), InlineEditor] public Pattern ViolinPattern;
}