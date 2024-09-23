#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using UnityEngine;

public class Rotator : MonoBehaviour
{

    public bool Rotate = true;
    [Range(10f, 100f)]
    public float Speed = 1.0f;

    void Update()
    {
        if (Rotate)
        {
            transform.Rotate(Vector3.up, Time.deltaTime * Speed);
        }
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
