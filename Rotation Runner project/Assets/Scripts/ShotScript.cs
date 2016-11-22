using UnityEngine;
using System.Collections;

public class ShotScript : MonoBehaviour {

    public int damage;

	// Update is called once per frame
	void Update () {
        if (GetComponent<Renderer>().isVisible == false)
        {
            Destroy(gameObject);
        }
    }
}
