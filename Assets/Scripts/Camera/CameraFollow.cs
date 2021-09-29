using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CameraFollow : MonoBehaviour
{
    // Deklarasi variabel
    public Transform target;
    public float smoothing = 5f;
    Vector3 offset;

    // Start is called before the first frame update
    private void Start()
    {
        //Dapat offset between the target and the camera
        offset = transform.position - target.position;
    }

    // Update is called once per frame
    private void Update()
    {
        // posisi untuk camera
        Vector3 targetCamPos = target.position + offset;
        
        //set posisi camera dengan smoothing tadi
        transform.position = Vector3.Lerp(transform.position, targetCamPos, smoothing * Time.deltaTime);
    }
}
