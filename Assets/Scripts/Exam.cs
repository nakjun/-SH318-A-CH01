using UnityEngine;
using UnityEngine.UI;

public class exam : MonoBehaviour
{
    public Button buttonActive;
    public GameObject panelObject;

    void Start()
    {
        if (buttonActive != null)
        {
            buttonActive.onClick.AddListener(TogglePanel);
        }
    }

    void TogglePanel()
    {
        if (panelObject != null)
        {
            panelObject.SetActive(!panelObject.activeSelf);
        }
    }
}

