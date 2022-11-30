using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Follow : MonoBehaviour
{
    [SerializeField] private Transform _target;

    private Tweener _tween;

    private void Start()
    {
        _tween = transform.DOMove(_target.position, 2);
    }
}
