using UnityEngine;
using System.Collections;

public class buttonListener : MonoBehaviour {

    void OnMouseDown()
    {


    }

    void OnMouseUp()
    {

    }

    void OnMouseUpAsButton()
    {
        switch (gameObject.name)
        {
            case "startButton":
                Application.LoadLevel("play");
                break;
            case "scoreButton":
                Application.OpenURL("http://google.com");
                break;
            case "exitButton":
                Application.Quit();
                break;
        }
    }
}
