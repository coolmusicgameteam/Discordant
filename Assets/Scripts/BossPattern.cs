using Boo.Lang;
using Sirenix.OdinInspector;
using UnityEngine;

[CreateAssetMenu(menuName = "Patterns/Boss")]
public class BossPattern : Pattern {
    [ShowInInspector, HideReferenceObjectPicker, ListDrawerSettings(Expanded = true, CustomAddFunction = "Add")]
    public List<BossPatternItem> Actions = new List<BossPatternItem>();

    public void Add() {
        Actions.Add(new BossPatternItem());
    }
}