using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Bg : MonoBehaviour {
    //public float moveSpeed;
    public float shootDistance=-25.7f;
    public float shootSpeed=-0.15f;

    void OnEnable()
    {
        StartCoroutine(Shoot());
    }

    void OnDisable()
    {
        StopAllCoroutines();
    }

    IEnumerator Shoot()
    {
        float travelledDistance = 0;
        while (travelledDistance < shootDistance)
        {
            travelledDistance += shootSpeed * Time.deltaTime;
            transform.position += transform.right * (shootSpeed * Time.deltaTime);
            yield return 0;
        }

        //Spawn a pooled explosion prefab
        //explosionPrefab.Spawn(transform.position);

        //Recycle this pooled bullet instance
        gameObject.Recycle();
    }
}
