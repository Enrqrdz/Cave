using System.Collections.Generic;
using UnityEngine;

public class Grid : MonoBehaviour
{
    [SerializeField] private float _size = 1f;
    [SerializeField] private float _height = .5f;
    public Dictionary<int,Vector3> Positions = new Dictionary<int, Vector3>();

    public float GetSize() => _size;
    public float GetHeight() => _height;

    public void SnapObjectToGrid(Transform target_)
    {
        target_.position = GetNearestPointOnGrid(target_.position);
        AddObjectToGridPositions(target_);
    }

    public Vector3 GetNearestPointOnGrid(Vector3 position_)
	{
		position_ -= transform.position;

		int xCount = Mathf.RoundToInt(position_.x / _size);
		int yCount = Mathf.RoundToInt(position_.y / _height);
		int zCount = Mathf.RoundToInt(position_.z / _size);

		Vector3 result = new Vector3(xCount * _size, yCount * _height, zCount * _size);
		result += transform.position;
		return result;
	}

    public void AddObjectToGridPositions(Transform object_)
    {
        var objectPosition = object_.position;
        var hashCode = objectPosition.GetHashCode();
        Positions[hashCode] = objectPosition;
    }
}

