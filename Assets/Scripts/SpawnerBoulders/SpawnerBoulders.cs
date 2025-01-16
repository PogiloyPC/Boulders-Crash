using UnityEngine;
using System.Collections;

public class SpawnerBoulders : MonoBehaviour
{
    [SerializeField] private BoulderFallLine[] _boulderFallLines;

    [SerializeField] private float _timeSpawn;

    private void Start()
    {
        StartCoroutine(SpawnBoulder());
    }

    private IEnumerator SpawnBoulder()
    {
        int numberFallLine = Random.RandomRange(_boulderFallLines.Length - _boulderFallLines.Length, _boulderFallLines.Length);

        yield return new WaitForSeconds(_timeSpawn);
    }
}