#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.PHASE;
using UnityEngine;

public class FootstepTrigger : MonoBehaviour
{
    public PHASESource Source;
    public bool TriggerSwitch;
    public float Frequency = 200;
    private int _counter = 0;

    [Range(0.0f, 1.0f)]
    [SerializeField] private float _wetness = 0.5f;

    void Update()
    {
        ++_counter;
        if (_counter > Frequency)
        {
            Source.Play();

            if (TriggerSwitch == true)
            {
                Source.SetMetaParameterValue("Terrain", "Wood");
            }
            else
            {
                Source.SetMetaParameterValue("Terrain", "Gravel");
            }
            Source.SetMetaParameterValue("Wetness", _wetness);
            _counter = 0;
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
