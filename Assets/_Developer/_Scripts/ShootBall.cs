using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootBall : MonoBehaviour
{
    private Camera _camera;

    [SerializeField] private Transform _ballParent;
    [SerializeField] private GameObject _ballPrefab;
    [SerializeField] private float _forceSpeed = 500f;

    
    // Start is called before the first frame update
    void Start()
    {
        _camera = FindAnyObjectByType<Camera>();
        UIManager.OnUIShootButtonClicked += ShootBallOnBtnClicked;
    }

    private void ShootBallOnBtnClicked()
    {
        float spawnPointOffset = 0.1f;
        Vector3 spawnPoint = _camera.transform.position + _camera.transform.forward * spawnPointOffset;
        Quaternion spawnRotation = _camera.transform.rotation;

        GameObject spawnedBall = Instantiate(_ballPrefab, spawnPoint, spawnRotation,_ballParent);
        Rigidbody rb = spawnedBall.GetComponent<Rigidbody>();

        if(rb != null)
        {
            rb.AddForce(_camera.transform.forward * _forceSpeed);
        }

        Destroy(spawnedBall, 5f);
    }


    private void OnDestroy()
    {
        UIManager.OnUIShootButtonClicked -= ShootBallOnBtnClicked;
    }
}
