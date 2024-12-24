using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ResetRBPositionOfObjects : MonoBehaviour
{
    private Rigidbody _rigidBody;

    private Vector3 _rbStartPosition;
    private Quaternion _rbStartRotation;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    // Start is called before the first frame update
    void Start()
    {
        UIManager.OnUIResetButtonClicked += ResetRBPositionOnBtnClicked;

        _rbStartPosition = _rigidBody.transform.localPosition;
        _rbStartRotation = _rigidBody.transform.localRotation;

    }

    private void ResetRBPositionOnBtnClicked()
    {
        _rigidBody.isKinematic = true;

        _rigidBody.transform.localPosition = _rbStartPosition;
        _rigidBody.transform.localRotation = _rbStartRotation;

        _rigidBody.velocity = Vector3.zero;
        _rigidBody.angularVelocity = Vector3.zero;
    }

    private void OnDestroy()
    {
        UIManager.OnUIResetButtonClicked -= ResetRBPositionOnBtnClicked;
    }
}
