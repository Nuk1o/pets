using System;
using UnityEngine;

public class Move_Camera : MonoBehaviour
{
    [SerializeField] private Camera _mainCam;

    private void Start()
    {
        _mainCam.transform.position = new Vector3(0,0,-10);
    }

    public void turn_left()
    {
        if (_mainCam.transform.position.x < 0)
        {
            Debug.Log("Дальше нельзя");
        }
        else
        {
            _mainCam.transform.position = new Vector3(_mainCam.transform.position.x - 19, 0, -10);
        }
    }

    public void turn_right()
    {
        if (_mainCam.transform.position.x > 0)
        {
            Debug.Log("Дальше нельзя");
        }
        else
        {
            _mainCam.transform.position = new Vector3(_mainCam.transform.position.x + 19, 0, -10);
        }
    }
}
