using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Rendering;

public class CameraRendering : MonoBehaviour {

	// Start is called before the first frame update
	void Start() {
		object[] obj = FindObjectsOfType(typeof(MeshRenderer));
		foreach (object o in obj) {
			MeshRenderer meshRenderer = (MeshRenderer)o;
			if (meshRenderer && meshRenderer.material.shader.name == "Shader Graphs/Hyperbolic") {
				meshRenderer.bounds = new Bounds(meshRenderer.transform.position, new Vector3(25f, 25f, 25f));
			}
		}
	}

    // Update is called once per frame
    void Update() {
    }
}
