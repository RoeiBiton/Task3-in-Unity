using UnityEngine;
using System.Collections;
using System.Collections.Generic;

public class DestroyCoin : MonoBehaviour
{
    // Start is called once before the first execution of Update after the MonoBehaviour is create
        [SerializeField] string triggeringTag;

    private void OnTriggerEnter2D(Collider2D other) {
        if (other.tag == triggeringTag && enabled) {
            Destroy(other.gameObject);
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
