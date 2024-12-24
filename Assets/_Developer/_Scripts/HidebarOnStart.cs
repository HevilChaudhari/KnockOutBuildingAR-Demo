using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HidebarOnStart : MonoBehaviour
{
    [SerializeField] private Canvas _arMagicbar;
    [SerializeField] private Canvas _crossHairCanvas;


    // Start is called before the first frame update
    void Start()
    {
        UIManager.OnUIStartButtonClicked += HideARMagicBar;
        UIManager.OnUIResetButtonClicked += ShowARMagicBar;

        _crossHairCanvas.enabled = false;
    }

    private void ShowARMagicBar()
    {
        _arMagicbar.enabled = true;
        _crossHairCanvas.enabled = false;
    }

    private void HideARMagicBar()
    {
        _arMagicbar.enabled = false;
        _crossHairCanvas.enabled = true;
    }

    private void OnDestroy()
    {
        UIManager.OnUIStartButtonClicked -= HideARMagicBar;
        UIManager.OnUIResetButtonClicked -= ShowARMagicBar;
    }

}
