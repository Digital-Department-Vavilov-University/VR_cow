using UnityEngine;

public class Syringe : MonoBehaviour
{
    private void OnTriggerEnter(Collider other)
    {
        if (other.CompareTag("InjectionZone"))
        {
            VetUIManager.Instance.ShowHint("Укол успешно выполнен!");
        }
    }
}