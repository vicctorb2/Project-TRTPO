using UnityEngine;
using System.Collections;

public class UIManagerScript : MonoBehaviour {


	public Animator startButton;
	public Animator difficultButton;
	public Animator contentPanel;
	public Animator goToMenuButton;

	public void StartGame()
	{
		Application.LoadLevel ("play");
	}

	public void GoToMenu()
	{
		Application.LoadLevel("menu");
	}

	public void OpenDifficult()
	{
		startButton.SetBool("isHidden", true);
		difficultButton.SetBool ("isHidden", true);
	}

	public void ToggleMenu()
	{
		contentPanel.enabled= true;
		bool isHidden = contentPanel.GetBool ("isHiding");
		contentPanel.SetBool ("isHiding", !isHidden);

	}

	void Start()
	{
		RectTransform transform = contentPanel.gameObject.transform as RectTransform;
		Vector2 position = transform.anchoredPosition;
		position.y -= transform.rect.height;
		transform.anchoredPosition = position;
	}
}
