using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
public class SethPracticeHandlingProblems : MonoBehaviour
{
    public List<string> oldBeliefList;
    public List<string> newBeliefList;
    public bool subtituteBelief = false;

    public GameObject oldObject;
    public GameObject oldObjectPrefabConstruction;
    public GameObject newObject;

    public Transform fearHolderObject;
    public TMP_Text[] fearObjects;
    public TMP_Text[] subtitutionObjects;
    public List<int> healthOfFearObject ;
    // Start is called before the first frame update
    void Start()
    {
        fearObjects = fearHolderObject.GetComponentsInChildren<TMP_Text>(true);
        clickCount = 0;
        healthOfFearObject = new List<int>();
        for(int i = 0; i < fearObjects.Length; i++)
        {
            healthOfFearObject.Add(1);
        }
        for(int i = 0; i < fearObjects.Length; i++)
        {
            fearObjects[i].text = oldBeliefList[i];
        }
    }
    public void OnRestart()
    {
        oldObject.gameObject.SetActive(true);
    }
    public void OnShowNewObjectConstruct()
    {
        oldObject.gameObject.SetActive(false);
        newObject.gameObject.SetActive(true);
    }
    int clickCount = 0;
    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButton(0))
        {
            RaycastHit hit;
            if(Physics.Raycast(Camera.main.ScreenPointToRay(Input.mousePosition),out hit)){
                //
                for(int i = 0; i < fearObjects.Length; i++)
                {
                  //  if (fearObjects[i].gameObject.activeInHierarchy)
                    {
                        if (Vector3.Distance(fearObjects[i].transform.position, hit.point) < 3)
                        {
                            healthOfFearObject[i]--;
                            if (healthOfFearObject[i] <= 0)
                            //fearObjects[i].text = newBeliefList[i];
                            {
                                if(subtituteBelief==false) fearObjects[i].gameObject.SetActive(false);
                                else fearObjects[i].text = newBeliefList[i];
                            }
                               
                        }
                    }
                }
            }
        }
    }
}
