using System;
using UnityEngine;
using UnityEngine.UI;

public class UIManager : MonoBehaviour
{


    [SerializeField] private Button _UIStartBtn;
    [SerializeField] private Button _UIShootBtn;
    [SerializeField] private Button _UIResetBtn;



    public static event Action OnUIStartButtonClicked;
    public static event Action OnUIShootButtonClicked;
    public static event Action OnUIResetButtonClicked;

    //=====Start Method=====//
    void Start()
    {
        _UIStartBtn.onClick.AddListener(OnStartBtnClicked);
        _UIShootBtn.onClick.AddListener(OnShootBtnClicked);
        _UIResetBtn.onClick.AddListener(OnResetBtnClicked);

        _UIShootBtn.gameObject.SetActive(false);
    }



    #region private Methods

    private void OnStartBtnClicked()
    {
        OnUIStartButtonClicked?.Invoke();

        _UIStartBtn.gameObject.SetActive(false);
        _UIShootBtn.gameObject.SetActive(true);
    }

    private void OnShootBtnClicked()
    {
        OnUIShootButtonClicked?.Invoke();
    }

    private void OnResetBtnClicked()
    {
        OnUIResetButtonClicked?.Invoke();

        _UIStartBtn.gameObject.SetActive(true);
        _UIShootBtn.gameObject.SetActive(false);
    }

    #endregion
}
