using UnityEngine;

public class SnapToGrid : MonoBehaviour
{
    private Grid _grid;
    private Grid Grid
    {
        get
        {
            if (_grid == null)
            {
                _grid = GameObject.Find("Grid").GetComponent<Grid>();
            }
            return _grid;
        }
    }

    private void OnValidate()
    {
        Grid.SnapObjectToGrid(transform);
    }

    private void Awake()
    {
        Grid.SnapObjectToGrid(transform);
    }
}
