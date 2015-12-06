using UnityEngine;

namespace Assets.Source
{
	public enum enPlayer
	{
		violet = 0,
		green = 1
	}

	class gVar
	{


		public const string prefKeyboard = "keyLay";
		public const string prefkeyNumLock = "keyNumLock";

		public static KeyCode[] keyAction1 = new KeyCode[] { KeyCode.Q, KeyCode.Keypad7 };
		public static KeyCode[] keyUp = new KeyCode[] { KeyCode.W, KeyCode.Keypad8 };
		public static KeyCode[] keyDown = new KeyCode[] { KeyCode.S, KeyCode.Keypad5 };
		public static KeyCode[] keyLeft = new KeyCode[] { KeyCode.A, KeyCode.Keypad4 };
		public static KeyCode[] keyRight = new KeyCode[] { KeyCode.D, KeyCode.Keypad6 };
		public static KeyCode[] keyRelease = new KeyCode[] { KeyCode.E, KeyCode.Keypad9 };
		public static KeyCode[] keyDeposeLightBulb = new KeyCode[] { KeyCode.Y, KeyCode.Keypad1 };
		public static KeyCode[] keySpeedSlow = new KeyCode[] { KeyCode.X, KeyCode.Keypad2 };
		public static KeyCode keyStart = KeyCode.Space;
		public static KeyCode keyHelp = KeyCode.H;
		public static KeyCode keyExit = KeyCode.F4;
		public static KeyCode keyCancel = KeyCode.Escape;

	}
}
