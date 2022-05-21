using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;
using UnityEngine.Events;

public class TowerSizeView : MonoBehaviour
{
    [SerializeField] private TMP_Text _siveView;
    [SerializeField] private Tower _tower;
    

    private void OnEnable()
    {
        _tower.SizeUpdated += OnSizeUpdate;
    }

    private void OnDisable()
    {
        _tower.SizeUpdated -= OnSizeUpdate;
        
    }

    private void OnSizeUpdate(int size)
    {
        _siveView.text = size.ToString();
    }
}
