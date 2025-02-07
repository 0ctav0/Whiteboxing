using UnityEngine;
using DG.Tweening;

public class Button : MonoBehaviour, IClickable
{
    [SerializeField] private Vector3 clickedOffset;
    [SerializeField] private float duration = 1;
    [SerializeField] private Activable objectToActivate;
    private bool clicked = false;

    public void Perform()
    {
        if (!clicked)
        {
            transform.DOMove(transform.position + clickedOffset, duration);
            objectToActivate.GetComponent<IActivable>().Activate();
            clicked = true;
        }
    }
}
