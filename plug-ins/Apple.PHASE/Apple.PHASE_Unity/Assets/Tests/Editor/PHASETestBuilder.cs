#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
﻿using Apple.Core.Tests.Editor;
using Apple.PHASE.UnitTests;
using System.Collections.Generic;
using UnityEditor.TestTools;
using UnityEngine.TestTools;

/*
 * Build the UnitTest player with:
 * /path/to/Unity.app/Contents/MacOS/Unity -runTests -batchmode -projectPath /path/to/PHASEUnityProject -testPlatform iOS -assemblyNames Tests
 */

[assembly: TestPlayerBuildModifier(typeof(PHASETestBuilder))]
[assembly: PostBuildCleanup(typeof(PHASETestBuilder))]

namespace Apple.PHASE.UnitTests
{
    public class PHASETestBuilder : AppleTestBuilder
    {
        public List<string> _testScenePaths = new List<string> {
            "Assets/Tests/Resources/TestAssets/TestScene.unity"
        };
    }
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
