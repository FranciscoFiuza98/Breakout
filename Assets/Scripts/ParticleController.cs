﻿
using UnityEngine;

public class ParticleController : MonoBehaviour {

    public ParticleSystem particles;

	// Use this for initialization
	void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
        if (Input.GetMouseButton(0))
        {
            particles.Emit(1);
        }
	}
}
