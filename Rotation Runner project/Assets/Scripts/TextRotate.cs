using UnityEngine;
using System.Collections;

public class TextRotate : MonoBehaviour {


    public float speed, tilt;
    private Vector3 target;
    public Vector3 targetUp;
    public Vector3 targetDown;
	
    void Start()
    {
        target = targetUp;
    }
   	// Update is called once per frame
	void Update () {
        transform.position = Vector3.MoveTowards(transform.position, target, Time.deltaTime * speed);
        if (transform.position == targetUp)
        {
            target = targetDown;
        }
        else if(transform.position == targetDown)
        {
            target = targetUp;
        }

        transform.Rotate(Vector3.right, Time.deltaTime * tilt);
	}
}
