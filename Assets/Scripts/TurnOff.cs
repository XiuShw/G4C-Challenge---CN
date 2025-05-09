using UnityEngine;
using UnityEngine.EventSystems;

public class TurnOff : MonoBehaviour, IPointerClickHandler
{
    public void OnPointerClick(PointerEventData eventData)
    {
        gameObject.SetActive(false);
    }
}
