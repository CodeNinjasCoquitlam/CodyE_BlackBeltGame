using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class AspectRatio : MonoBehaviour
{
    [SerializeField] private Dropdown aspectRatioDropdown;
    [SerializeField] private Camera mainCamera;

    private void Start()
    {
        if (aspectRatioDropdown != null)
        {
            aspectRatioDropdown.onValueChanged.AddListener(ChangeAspectRatio);
        }
        else
        {
            Debug.LogError("Aspect Ratio Dropdown not assigned.");
        }

        if (mainCamera == null)
        {
            mainCamera = Camera.main;
        }
    }

    private void ChangeAspectRatio(int index)
    {
        switch (index)
        {
            case 0: SetAspectRatio(16f, 9f); break;
            case 2: SetAspectRatio(4f, 3f); break;
            case 1: SetAspectRatio(21f, 9f); break;
           
            default: Debug.LogWarning("Unknown aspect ratio index."); break;
        }
    }

    private void SetAspectRatio(float width, float height)
    {
        float targetAspect = width / height;
        float windowAspect = (float)Screen.width / Screen.height;
        float scaleHeight = windowAspect / targetAspect;

        Rect rect = mainCamera.rect;

        if (scaleHeight < 1.0f)
        {
            rect.width = 1.0f;
            rect.height = scaleHeight;
            rect.x = 0;
            rect.y = (1.0f - scaleHeight) / 2.0f;
        }
        else
        {
            float scaleWidth = 1.0f / scaleHeight;
            rect.width = scaleWidth;
            rect.height = 1.0f;
            rect.x = (1.0f - scaleWidth) / 2.0f;
            rect.y = 0;
        }

        mainCamera.rect = rect;
    }

}
