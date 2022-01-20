using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Collector : MonoBehaviour
{
    public GameObject mainCube;
    public int h;
    

    void Update()
    {
        
        this.transform.localPosition = new Vector3(0, -h, 0);
    }
    public void RemoveHeight()
    {
        h--;
        mainCube.gameObject.GetComponent<Movement>().h = this.h;
    }
    private void OnTriggerEnter(Collider other)
    {
        if(other.gameObject.tag == "Sum" && !other.gameObject.GetComponent<SumCube>().GetBefore())
        {
            h++;
            mainCube.gameObject.GetComponent<Movement>().h = this.h;
            other.gameObject.GetComponent<SumCube>().Make();
            other.gameObject.GetComponent<SumCube>().SetIndex(h);
            other.gameObject.transform.parent = mainCube.transform;
        }
    }
}
