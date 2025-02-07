using UnityEngine;
using DG.Tweening;

public class SlideDoor : Activable, IActivable
{
    [SerializeField] private Vector3 slideToOffset;
    [SerializeField] private float duration = 1;
    private bool activated = false;
    public void Activate()
    {
        if (!activated)
        {
            transform.DOMove(transform.position + slideToOffset, duration);
            activated = true;
        }
    }
}
