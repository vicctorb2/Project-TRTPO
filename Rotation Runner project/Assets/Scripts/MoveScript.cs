using UnityEngine;
using System.Collections;

public class MoveScript : MonoBehaviour {

    public float speed;
    public Vector2 direction;

    private Vector2 movement;

	// Use this for initialization
	void Start () {
	
	}
	
	// Update is called once per frame
	void Update () {
        movement = new Vector2(speed * direction.x, speed * direction.y);
	}

    void FixedUpdate()
    {
        GetComponent<Rigidbody2D>().velocity = movement;
    }

	public Vector2 GetMovement(){
		return movement;
	}
}
