using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Movement : MonoBehaviour
{
    [SerializeField] private float forwardSpeed;
    [SerializeField] private float rightleftSpeed;
    public int h;
    private void Start()
    {
        h = this.transform.Find("SumOfCube").GetComponent<Collector>().h;
    }
    void Update()
    {

        float y = Input.GetAxis("Horizontal") * rightleftSpeed * Time.deltaTime;

        this.transform.position = new Vector3(Mathf.Clamp(transform.position.x + y,-5,5),h+1,Mathf.Clamp(this.transform.position.z +forwardSpeed*Time.deltaTime,-250,250));
        
        
    }
}
