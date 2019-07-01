using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnvController : MonoBehaviour {
    public Bg bg;
    public Transform parent;
    private Vector3 startPos = new Vector3(-1.45f, 4.50f, -0.15f);
	// Use this for initialization
	void Start () {
        
        bg.Spawn(parent,startPos, Quaternion.identity);
        
        //envObjects = new GameObject[transform.childCount];
        //for (int i = 0; i < transform.childCount; i++)
        //{
        //    envObjects[i] = transform.GetChild(i).gameObject;
        //}
        //print(envObjects.Length);
	}
	
	// Update is called once per frame
	void Update () {
        //for (int i = 0; i < envObjects.Length; i++)
        //{
        //    if (envObjects[i].name=="bg")
        //    {
        //        envObjects[i].transform.Translate(new Vector3(-0.05f, 0, 0));
        //    }
        //    if (envObjects[i].name == "op")
        //    {
        //        envObjects[i].transform.Translate(new Vector3(-0.07f, 0, 0));
        //    }
        //}
        GameObject go= bg.Spawn(startPos, Quaternion.identity).gameObject;
        go.SetActive(true);
        
    }
}
