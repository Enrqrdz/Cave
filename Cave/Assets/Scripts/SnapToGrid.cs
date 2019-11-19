using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class SnapToGrid : MonoBehaviour
{
	Grid grid;

	void Start()
	{
		grid = GameObject.FindGameObjectWithTag("Grid").GetComponent<Grid>();
		grid.SnapObjectToGrid(gameObject);
	}

	void Update()
	{
		if (transform.hasChanged)
		{
			grid.SnapObjectToGrid(gameObject);
		}
	}
}
