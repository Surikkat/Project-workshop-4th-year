using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ProgramBehaviour : MonoBehaviour
{
    public int itemID = 0;
    public Vector3 camOffset = new Vector3(0f, 1.2f, -2.6f);
    public GameObject Camera;
    public Transform target;

    public GameObject Spawnpoint;
    public GameObject bed;
    public GameObject sofa;
    public GameObject bedsideTable;
    public GameObject closet;

    private float vInput;
    private float hInput;

    public void Bed()
    {
        itemID = 1;
        Instantiate(bed, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Camera.transform.position = GameObject.Find("PFB_Bed(Clone)").transform.TransformPoint(camOffset);
    }

    public void Sofa()
    {
        itemID = 2;
        Instantiate(sofa, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Camera.transform.position = GameObject.Find("PFB_BedroomSofa(Clone)").transform.TransformPoint(camOffset);
    }

    public void BedsideTable()
    {
        itemID = 3;
        Instantiate(bedsideTable, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Camera.transform.position = GameObject.Find("PFB_BedsideTable(Clone)").transform.TransformPoint(camOffset);
    }

    public void Closet()
    {
        itemID = 4;
        Instantiate(closet, Spawnpoint.transform.position, Spawnpoint.transform.rotation);
        Camera.transform.position = GameObject.Find("PFB_Closet(Clone)").transform.TransformPoint(camOffset);
    }

    public void LateUpdate()
    {
        if(itemID == 1)
        {
            Camera.transform.LookAt(GameObject.Find("PFB_Bed(Clone)").transform);
        }
        if (itemID == 2)
        {
            Camera.transform.LookAt(GameObject.Find("PFB_BedroomSofa(Clone)").transform);
        }
        if (itemID == 3)
        {
            Camera.transform.LookAt(GameObject.Find("PFB_BedsideTable(Clone)").transform);
        }
        if (itemID == 4)
        {
            Camera.transform.LookAt(GameObject.Find("PFB_Closet(Clone)").transform);
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        vInput = Input.GetAxis("Vertical") * 10f;
        hInput = Input.GetAxis("Horizontal") * 75f;

        Camera.transform.Translate(Vector3.forward * hInput * Time.deltaTime);
        Camera.transform.Translate(Vector3.up * vInput * Time.deltaTime);
    }
}
