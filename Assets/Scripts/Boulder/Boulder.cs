using UnityEngine;

public abstract class Boulder : MonoBehaviour
{
    private BoulderFallLine _fallLine;

    [SerializeField, Range(1, 2)] private readonly int _startHealth;
    private int _currentHealth;

    [SerializeField] private float _speed;

    private void Start()
    {
        _currentHealth = _startHealth;
    }

    public void InitializationBoulder(BoulderFallLine fallLine)
    {
        _fallLine = fallLine;
    }

    private void OnTriggerEnter(Collider collision)
    {
        
    }
}