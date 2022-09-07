﻿using Scripts.Utils;
using UnityEngine;

namespace Scripts
{
    public class EnterTriggerComponent : MonoBehaviour
    {
    [SerializeField] private string _tag;
    [SerializeField] private LayerMask _layer = ~0;
    [SerializeField] private EnterEvent _action;

    private void OnTriggerEnter(Collider other)
    {
        if (!other.gameObject.IsInLayer(_layer)) return;
        if (!string.IsNullOrEmpty(_tag) && !string.IsNullOrEmpty(other.gameObject.tag) && !other.gameObject.CompareTag(_tag)) return;

        _action?.Invoke(other.gameObject);
    }
    }
}