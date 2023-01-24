using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Events;

public class PlayerCollisionHandler : MonoBehaviour
{
    [SerializeField]
    private UnityEvent _playerDied;
    [SerializeField]
    private UnityEvent _squareCollected;
    
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.CompareTag(GlobalConstants.ALLY_TAG))
        {
            _squareCollected.Invoke();
            Destroy(collider.gameObject);
        }

        if (collider.CompareTag(GlobalConstants.ENEMY_TAG))
        {
            _playerDied.Invoke();
            Destroy(collider.gameObject);
        }
    }
}
