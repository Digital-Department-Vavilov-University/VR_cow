using UnityEngine;

public class InspectableArea : MonoBehaviour
{
    public string areaName;

    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("Hand"))
        {
            VetUIManager.Instance.ShowHint($"Проверка области: {areaName}");
        }
    }
}