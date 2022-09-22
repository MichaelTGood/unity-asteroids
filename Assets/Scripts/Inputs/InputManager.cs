using UnityEngine.InputSystem;

public class InputManager
	{
		#region Variables

		private static MainInputs Input = new MainInputs();

		#endregion

		#region Properties

		public static MainInputs.ShipStandardActions ShipStandard => Input.ShipStandard;

		public static MainInputs.MenuActions Menu => Input.Menu;

		#endregion
		
		public static void SwitchToActionMap(InputActionMap actionMap)
		{
			if(actionMap.enabled) return;

			Input.Disable();
			actionMap.Enable();
		}
	}