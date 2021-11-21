using UnityEngine;

// This script will spawn a prefab when you tap the screen
public class SimpleTap : MonoBehaviour
{
	
	protected virtual void OnEnable()
	{
		// Hook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap += OnFingerTap;
	}
	
	protected virtual void OnDisable()
	{
		// Unhook into the OnFingerTap event
		Lean.LeanTouch.OnFingerTap -= OnFingerTap;
	}
	
	public void OnFingerTap(Lean.LeanFinger finger)
	{
		FindObjectOfType<AudioManager>().Play("WolfHowl");
	}
}