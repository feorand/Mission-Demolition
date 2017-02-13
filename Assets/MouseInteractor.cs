using UnityEngine;
using UnityEngine.Events;

public class MouseInteractor : MonoBehaviour {

	public UnityEvent MouseEntered;
	public UnityEvent MouseExited;

	void OnMouseEnter() {
		MouseEntered.Invoke();
	}

	void OnMouseExit() {
		MouseExited.Invoke();
	}
}
