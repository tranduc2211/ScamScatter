using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Mun : MonoBehaviour
{
    public static List<Mun> muns = new();
    private void OnEnable()
    {
        muns.Add(this);
    }
    private void OnDisable()
    {
        muns.Remove(this);
    }
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
