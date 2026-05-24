using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkinCleaner : MonoBehaviour
{
    RectTransform rect;
    // Start is called before the first frame update
    void Start()
    {
        rect = GetComponent<RectTransform>();
    }

    // Update is called once per frame
    void Update()
    {
        rect.position = Input.mousePosition;
        if (Input.GetMouseButton(0))
        {
            for(int i = 0; i < Mun.muns.Count; i++)
            {
                if (Mun.muns[i].gameObject.activeInHierarchy == false) continue;

                RectTransform rectMun = Mun.muns[i].GetComponent<RectTransform>();
                if (Vector3.Distance(rectMun.position, rect.position) < 20)
                {
                    rectMun.gameObject.SetActive(false);
                }
            }
        }
    }
}
