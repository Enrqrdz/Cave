using System.Collections;
using System.Collections.Generic;
using UnityEngine;

[ExecuteInEditMode]
public class Grid : MonoBehaviour
{
	[SerializeField]
	private float size = 1f;

	[SerializeField]
	private float height = .5f;

	public void SnapObjectToGrid(GameObject target)
	{
		target.transform.position = GetNearestPointOnGrid(target.transform.position);
	}

	public Vector3 GetNearestPointOnGrid(Vector3 position)
	{
		position -= transform.position;

		int xCount = Mathf.RoundToInt(position.x / size);
		int yCount = Mathf.RoundToInt(position.y / height);
		int zCount = Mathf.RoundToInt(position.z / size);

		Vector3 result = new Vector3(xCount * size, yCount * height, zCount * size);
		result += transform.position;
		return result;
	}
}

