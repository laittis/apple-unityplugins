#if (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
using System.Collections;
using UnityEngine;
using UnityEngine.TestTools;

using Apple.Core;

namespace Apple.CoreHaptics.Tests {
	public class CHOneShotEngineTestSuite {

		[UnityTest]
		public IEnumerator Test_Engine_OneShotEngineExists() {
			_ = new AppleLogger();

			var oneShot = CHHapticEngine.OneShotEngine;
			yield return new WaitForSeconds(0.1f);

			UnityEngine.Assertions.Assert.IsNotNull(oneShot, "Failed to find the OneShot engine");
		}


	}
}
#endif // (UNITY_EDITOR_OSX || UNITY_IOS || UNITY_TVOS || UNITY_STANDALONE_OSX || UNITY_VISIONOS)
