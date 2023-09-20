using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CanvasManager : MonoBehaviour
{
    [SerializeField] private GameObject _canvasFirstShoot;
    private bool _isShootFirstCanvas;

    public bool isShootFirstCanvas
    {
        get => _isShootFirstCanvas;
        set
        {
            if (!_isShootFirstCanvas)
            {
                _canvasFirstShoot.SetActive(true);
            }
            _isShootFirstCanvas = value;
        }
    }
}
