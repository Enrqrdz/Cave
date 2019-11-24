using UnityEngine;

public static class InputManager
{
    public static bool Up
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.Space))
            {
                return true;
            }
            return false;
        } 
    }

    public static bool Down
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.LeftControl))
            {
                return true;
            }
            return false;
        }
    }

    public static bool Forward
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.W))
            {
                return true;
            }
            return false;
        }
    }

    public static bool Back
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.S))
            {
                return true;
            }
            return false;
        }
    }

    public static bool Left
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.A))
            {
                return true;
            }
            return false;
        }
    }

    public static bool Right
    {
        get
        {
            if (Input.GetKeyDown(KeyCode.D))
            {
                return true;
            }
            return false;
        }
    }
}
