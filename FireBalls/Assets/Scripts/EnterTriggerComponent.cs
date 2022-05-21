using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnterTriggerComponent : MonoBehaviour
{
    [SerializeField] private string _tag;
    [SerializeField] private UnityEventQueueSystem _action;
    private ReloadSceneComponent _reloadSceneComponent;

    private void OnTriggerEnter(Collider other)
    {
        if (other.gameObject.CompareTag(_tag))
        {
            _reloadSceneComponent.Reload();
        }
    }
}
