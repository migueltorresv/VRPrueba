using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public enum TypeMovement
{
    Normal,
    HorizontalLeft,
    HorizontalRight,
    VerticalTop,
}

public class TargetAnimation : MonoBehaviour
{
    [SerializeField] private Animator _animatorController;
    [SerializeField] private string _nameBoolParameter;
    [SerializeField] private TypeMovement _typeMovement;
    [SerializeField] private UnityEvent OnBreakAnimationFinished;

    private void Start()
    {
        SetHorizontalMovement();
    }

    public void BreakAnimationFinished()
    {
        OnBreakAnimationFinished?.Invoke();
    }
    
    public void ChangeParameterBool()
    {
        var parameter = _animatorController.GetBool(_nameBoolParameter);
        _animatorController.SetBool(_nameBoolParameter, !parameter);
    }

    public void EnableTarget()
    {
        _animatorController.gameObject.SetActive(true);
    }

    private void SetHorizontalMovement()
    {
        switch (_typeMovement)
        {
            case TypeMovement.Normal:
                _animatorController.SetLayerWeight(1,0.0f);
                _animatorController.SetLayerWeight(2,0.0f);
                _animatorController.SetLayerWeight(3,0.0f);
                break;
            case TypeMovement.HorizontalLeft:
                _animatorController.SetLayerWeight(1,1.0f);
                _animatorController.SetLayerWeight(2,0.0f);
                _animatorController.SetLayerWeight(3,0.0f);
                break;
            case TypeMovement.HorizontalRight:
                _animatorController.SetLayerWeight(1,0.0f);
                _animatorController.SetLayerWeight(2,1.0f);
                _animatorController.SetLayerWeight(3,0.0f);
                break;
            case TypeMovement.VerticalTop:
                _animatorController.SetLayerWeight(1,0.0f);
                _animatorController.SetLayerWeight(2,0.0f);
                _animatorController.SetLayerWeight(3,1.0f);
                break;
        }
    }

    private void OnEnable()
    {
        SetHorizontalMovement();
    }
}
