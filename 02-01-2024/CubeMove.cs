using UnityEngine;
using System.Collections;


public class MyCustomScript : MonoBehaviour {

    public int numFrames = 100;
    public UnityEvent OnPlayerShoot;

	// Use this for initialization
    void Start () {
	
	}
	
	// Update is called once per frame
    void Update () {
        if(Input.GetKeyDown(KeyCode.C)) {
            StartCoroutine("MoveCouroutine");
        }

        if(Input.GetKeyDown(KeyCode.Y)) {
            OnPlayerShoot.Invoke();
        }
	}

    void MoveFunction() {
        for(int i = 0; i < numFrames; i++) {
            gameObject.transform.position = new Vector3(0.01, 0, 0);
        }
    }

    void MoveCoroutine() {

    }
}