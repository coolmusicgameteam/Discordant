using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/Flute")]
public class FlutePattern : Pattern {
    [ShowInInspector, HideReferenceObjectPicker, ListDrawerSettings(Expanded = true, CustomAddFunction = "Add")]
    public List<FlutePatternItem> Actions = new List<FlutePatternItem>();

    public void Add() {
        Actions.Add(new FlutePatternItem());
    }
}