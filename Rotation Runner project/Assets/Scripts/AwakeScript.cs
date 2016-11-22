using UnityEngine;
using System.Collections;

public class AwakeScript : MonoBehaviour {
    public GameObject barrier;
	void Update () {
	   if(Input.GetMouseButtonDown(0))
        {
            Vector2 mousePos = Camera.main.ScreenToWorldPoint(Input.mousePosition);
			GameObject obj = GameObject.Find("shot(Clone)");
			if (obj == null) {
				Instantiate (barrier, mousePos, Quaternion.identity);
			}
        }
	}
}