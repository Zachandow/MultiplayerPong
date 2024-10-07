using UnityEngine;
using TMPro;

[RequireComponent(typeof(TMP_Text))]
public class TextUpdater : MonoBehaviour
{
    private TMP_Text textObj;

    void Awake()
    {
        textObj = GetComponent<TMP_Text>();
        if (textObj == null)
        {
            Debug.LogError("TMP_Text component is missing from this GameObject.");
        }
    }

    public void ShowInt(int value)
    {
        if (textObj != null)
        {
            textObj.text = value.ToString();
            Debug.Log($"Score updated: {value}");
        }
    }

    public void ShowFloat(float value)
    {
        if (textObj != null)
        {
            textObj.text = value.ToString();
            Debug.Log($"Float updated: {value}");
        }
    }

    public void ShowString(string value)
    {
        if (textObj != null)
        {
            textObj.text = value;
            Debug.Log($"Float updated: {value}");
        }
    }
}
