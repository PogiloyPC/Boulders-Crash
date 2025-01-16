using UnityEngine;

public class BoulderFallLine : MonoBehaviour
{
    [SerializeField] private Point _startPoint;
    [SerializeField] private Point _finishPoint;

    public Point GetStartPoint() => _startPoint;

    public Point GetFinishPoint() => _finishPoint;
}