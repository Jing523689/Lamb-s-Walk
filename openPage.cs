using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class openPage : MonoBehaviour
{
    // Start is called before the first frame update
    private Transform Canvas;
    public GameObject 页面;
    public GameObject 当前页面;
    void Start()
    {
        Canvas = GameObject.Find("Canvas").transform;
    }
    public void 打开页面()
    {
        GameObject 当前页 = Instantiate(页面, Canvas);
        当前页.SetActive(true);
        Destroy(当前页面);
    }
    // Update is called once per frame
    void Update()
    {
        
    }
}
