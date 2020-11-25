using UnityEngine;
using System.Collections;

#if UNITY_EDITOR
    using UnityEditor;
#endif
	
public class MapMaker : MonoBehaviour {

	Vector3[] slopeVertices = new Vector3[]{
		new Vector3(-0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, -0.5f, 0.5f),
		new Vector3(-0.5f, -0.5f, 0.5f),

		new Vector3(-0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, 0.5f, -0.5f),

		new Vector3(0.5f, -0.5f, 0.5f),
		new Vector3(-0.5f, -0.5f, 0.5f),
		new Vector3(0.5f, 0.5f, 0.5f),

		new Vector3(-0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, 0.5f, -0.5f),
		new Vector3(0.5f, 0.5f, 0.5f),
		new Vector3(-0.5f, -0.5f, 0.5f),

		new Vector3(0.5f, -0.5f, -0.5f),
		new Vector3(0.5f, -0.5f, 0.5f),
		new Vector3(0.5f, 0.5f, 0.5f),
		new Vector3(0.5f, 0.5f, -0.5f),
	};

	int[] slopeTriangles = new int[]{
		0, 1, 2,
		0, 2, 3,
		4, 6, 5,
		8, 7, 9,
		10, 12, 11,
		10, 13, 12,
		14, 17, 15,
		15, 17, 16,
	};
	
	GameObject makeSlope () {
		GameObject obj = GameObject.CreatePrimitive (PrimitiveType.Cube);
		obj.name = "Slope";

		Mesh mesh = obj.GetComponent<MeshFilter>().mesh;
		mesh.Clear ();
		mesh.vertices = slopeVertices;
		mesh.triangles = slopeTriangles;
		mesh.RecalculateNormals ();

		return obj;
	}

	// Use this for initialization
	void Start () {
		MakeMap (new Map02 ());
	}

	void MakeMap(IMapData mapData) {

			GameObject player = GameObject.Find ("Player");
			//player.transform.position = new Vector3(mapData.PlayerStart.x, mapData.PlayerStart.y + 1, mapData.PlayerStart.z);
			//player.transform.position = new Vector3(5, 1, 5);
			player.GetComponent<MoveCharacter>().Init();
			
	}
	
	// Update is called once per frame
	void Update () {
						
	}
}
