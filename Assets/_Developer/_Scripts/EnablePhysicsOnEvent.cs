using UnityEngine;

public class EnablePhysicsOnEvent : MonoBehaviour
{
     private Rigidbody _rigidBody;

    private void Awake()
    {
        _rigidBody = GetComponent<Rigidbody>();
    }

    //=====Start Method
    void Start()
    {
        UIManager.OnUIStartButtonClicked += StartPhysicsOnClicked;

        _rigidBody.isKinematic = true;
    }

    private void StartPhysicsOnClicked()
    {
        _rigidBody.isKinematic = false;
        _rigidBody.useGravity = true;
    }


    private void OnDestroy()
    {
        UIManager.OnUIStartButtonClicked -= StartPhysicsOnClicked;
    }
}
