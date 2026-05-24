using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinFixingManager : MonoBehaviour
{
    public GameObject newConstruction;
    public GameObject old;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void SetNewConstruction()
    {
        newConstruction.SetActive(true);
        old.SetActive(false);
    }
    public void SetOldConstruction()
    {
        old.SetActive(true);
        newConstruction.SetActive(false);
    }
}
