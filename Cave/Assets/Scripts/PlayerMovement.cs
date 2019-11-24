using System;
using UnityEngine;

public class PlayerMovement : MonoBehaviour
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
    public Action MovedEvent;
    private float _movementSize => Grid.GetSize();
    private Vector3 Forward => transform.position + _movementSize * Vector3.forward;
    private Vector3 Back => transform.position + _movementSize * Vector3.back;
    private Vector3 Left => transform.position + _movementSize * Vector3.left;
    private Vector3 Right => transform.position + _movementSize * Vector3.right;

    private void Update()
    {
        if (InputManager.Forward)
        {
            Move(Forward);
            MovedEvent?.Invoke();
        }

        if (InputManager.Back)
        {
            Move(Back);
            MovedEvent?.Invoke();
        }

        if (InputManager.Left)
        {
            Move(Left);
            MovedEvent?.Invoke();
        }

        if (InputManager.Right)
        {
            Move(Right);
            MovedEvent?.Invoke();
        }
    }

    private void Move(Vector3 newPosition_)
    {
        if (Grid.Positions.TryGetValue(newPosition_.GetHashCode(), out var newMoveToPosition))
        {
            transform.position = newMoveToPosition;
        }
    }

    private void OnDestroy()
    {
        foreach(var action in MovedEvent.GetInvocationList())
        {
            MovedEvent -= (action as Action);
        }
    }
}
