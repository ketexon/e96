using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HW2Arrow : MonoBehaviour
{
    [SerializeField] float speed = 8;

    new Renderer renderer;

    void Awake()
    {
        renderer = GetComponent<Renderer>();
    }

    void Update()
    {
        transform.position += speed * Time.deltaTime * (transform.rotation * Vector3.right);

        var frustum = GeometryUtility.CalculateFrustumPlanes(Camera.main);
        if(!GeometryUtility.TestPlanesAABB(frustum, renderer.bounds))
        {
            Destroy(gameObject);
        }
    }
}
