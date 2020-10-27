using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Utils;
public class ProbarDLL : MonoBehaviour
{
    private Utils.MyUtils util;
    // Start is called before the first frame update
    void Start()
    {
        util = new MyUtils();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.Log("Mi nombre es " + util.miNombre());
    }
}
