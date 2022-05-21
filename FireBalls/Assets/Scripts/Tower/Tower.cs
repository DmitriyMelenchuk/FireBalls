using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

[RequireComponent(typeof(TowerBulder))]
public class Tower : MonoBehaviour
{
    private TowerBulder _towerBulder;
    private List<Block> _blocks;
    private ReloadSceneComponent _reloadScene;

    public event UnityAction<int> SizeUpdated;

    private void Start()
    {
        _towerBulder = GetComponent<TowerBulder>();
        _blocks = _towerBulder.Build();

        foreach (var block in _blocks)
        {
            block.BulletHit += OnBulletHit;
        }
        
        
        
    }

    private void OnBulletHit(Block hitedBlock)
    {
        hitedBlock.BulletHit -= OnBulletHit;

        _blocks.Remove(hitedBlock);

        foreach (var block in _blocks)
        {
            block.transform.position = new Vector3(block.transform.position.x, block.transform.position.y - block.transform.localScale.y,block.transform.position.z);
        }
        SizeUpdated?.Invoke(_blocks.Count);
        
    }
}
