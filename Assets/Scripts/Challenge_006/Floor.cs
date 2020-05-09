using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Floor : MonoBehaviour
{
    MeshRenderer _meshRenderer;
    // Start is called before the first frame update
    void Start()
    {
        _meshRenderer = gameObject.GetComponent<MeshRenderer>();   
    }

    private void OnTriggerEnter(Collider other) {
        if (other.tag == "Player")
        {
            _meshRenderer.material.color = Color.blue;

            Destroy(other.gameObject);
        }    
    }
}
