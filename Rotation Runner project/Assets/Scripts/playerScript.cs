using UnityEngine;
using System.Collections;

public class playerScript : MonoBehaviour {

    public float speed;
    public Vector2 direction;
	public Vector2 bulletPosition;
	public GameObject bullet;


    private Vector2 movement;
	// Use this for initialization
	void Start () {
		
	}

	// Update is called once per frame
	void Update () {
        float inputX = Input.GetAxis("Horizontal");
        float inputY = Input.GetAxis("Vertical");
		GameObject stht =  GameObject.Find("shot(Clone)");
		if (stht != null) {
			Debug.Log (stht.transform.position);
		}
		movement = new Vector2 (speed * bulletPosition.x, speed * bulletPosition.y);
	}

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }

}
