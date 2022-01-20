using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SumCube : MonoBehaviour
{
    bool getBefore;
    int index;
    public Collector collector;
    GameObject mainCube,c;
    void Start()
    {
        mainCube = GameObject.Find("Main Cube");
        c = GameObject.Find("SumOfCube");
    }

    void Update()
    {
        if (getBefore)
        {
            if(transform.parent != null)
            {
                transform.localPosition = new Vector3(0, -index, 0);
            }
        }
        
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Block")
        {
            collector.RemoveHeight();
            transform.parent = null;
            GetComponent<BoxCollider>().enabled = false;
            other.gameObject.GetComponent<BoxCollider>().enabled = false;
        }
    }
    public bool GetBefore()
    {
        return getBefore;
    }
    public void Make()
    {
        getBefore = true;
    }
    public void ReturnBefore()
    {
        getBefore = false;
    }
    public void SetIndex(int index)
    {
        this.index = index;
    }
}
