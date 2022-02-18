using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ObjectPlacementManager : MonoBehaviour
{
    public Camera cam;
    public Transform placeableObject;
    public LayerMask mask;

    void Update()
    {
        Ray ray = cam.ScreenPointToRay(Input.mousePosition);
        RaycastHit hitInfo;

        if(Physics.Raycast(ray, out hitInfo, Mathf.Infinity, mask))
        {
            placeableObject.position = hitInfo.point + new Vector3(0, 0.5f, 0);
            placeableObject.rotation = Quaternion.FromToRotation(Vector3.up, hitInfo.normal);
        }
    }
}
