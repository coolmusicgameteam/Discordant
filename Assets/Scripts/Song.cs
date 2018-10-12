using System.Collections.Generic;
using Sirenix.OdinInspector;
using UnityEngine;

namespace DefaultNamespace {
    public class Song : MonoBehaviour {

        public AudioClip song;

        [InlineEditor]
        public List<Section> sections;

    }
}