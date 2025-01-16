using UnityEngine;
using DG.Tweening;
using System;

public class Player : MonoBehaviour, IPlayerDamageDiller
{
    [SerializeField] private PlayerAreaAttack _areaAttack;

    [SerializeField] private Point[] _pointsRoll;

    private Action _onEnableAstral;
    private Action _onAttack;
    private Action<bool> _onRoll;

    [SerializeField] private float _speedRoll;
    [SerializeField] private float _timeGhostState;

    private const int _damage = 1;

    private int _numberCurrentPoint;

    private void OnEnable()
    {
        _onEnableAstral += TurnAstralState;
        _onRoll += Roll;
        _onAttack += Attack;
    }

    private void OnDisable()
    {
        _onEnableAstral -= TurnAstralState;
        _onRoll -= Roll;
        _onAttack -= Attack;
    }

    private void Start()
    {
        int numberPoint = UnityEngine.Random.Range(0, _pointsRoll.Length);

        _numberCurrentPoint = numberPoint;

        transform.position = _pointsRoll[_numberCurrentPoint].GetPosition();
    }

    public void Initialization(out Action onEnableAstral, out Action onAttack, out Action<bool> onRoll)
    {
        onEnableAstral = _onEnableAstral;
        onAttack = _onAttack;
        onRoll = _onRoll;
    }

    private void Roll(bool isRightRoll)
    {
        Point currentPoint = _pointsRoll[_numberCurrentPoint];

        if (isRightRoll)
        {
            if (_numberCurrentPoint >= _pointsRoll.Length)
                return;
            else
                _numberCurrentPoint++;
        }
        else
        {
            if (_numberCurrentPoint <= _pointsRoll.Length - _pointsRoll.Length)
                return;
            else
                _numberCurrentPoint--;
        }

        Point newPoint = _pointsRoll[_numberCurrentPoint];

        transform.DOMove(newPoint.GetPosition(), _speedRoll, false);
    }

    private void Attack()
    {
        _areaAttack.CheckAreaAttack(this);
    }

    private void TurnAstralState()
    {

    }

    public int GetDamage() => _damage;
}