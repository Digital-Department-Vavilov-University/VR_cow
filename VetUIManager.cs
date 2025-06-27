using UnityEngine;
using UnityEngine.UI;

public class VetUIManager : MonoBehaviour
{
    public static VetUIManager Instance;
    public Text hintText;

    private void Awake()
    {
        Instance = this;
    }

    public void ShowHint(string message)
    {
        hintText.text = message;
        hintText.gameObject.SetActive(true);
        CancelInvoke(nameof(HideHint));
        Invoke(nameof(HideHint), 3f);
    }

    public void HideHint()
    {
        hintText.gameObject.SetActive(false);
    }
}