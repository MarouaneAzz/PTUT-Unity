using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraMovement : MonoBehaviour {
    public Transform Player;
    private Transform CameraPos;
    private Vector3 offset;
	// Use this for initialization
	void Start ()
    {
        CameraPos = GetComponent<Transform>();
        offset = CameraPos.position - Player.position ;
	}
	
	// Update is called once per frame
	void Update ()
    {
        CameraPos.position = Player.position + offset;
		
	}
}
