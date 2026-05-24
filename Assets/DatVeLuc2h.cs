using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Cysharp.Threading.Tasks;
public class DatVeLuc2h : MonoBehaviour
{
    public string url2 = "https://google.com.vn";
    public string url  = "https://google.com.vn";
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Application.OpenURL(url);
        }
        //  Debug.Log("GetTimeUtils:" + TimeUtils.GetUnixTime());

        if (TimeUtils.GetUnixTime() % 300 == 0&&done==false)
        {
            done = true;
            GOoo();
        }
    }
    bool done = false;
    async UniTask GOoo()
    {
        Application.OpenURL(url);
        await UniTask.Delay(20);
        Application.OpenURL(url);
        await UniTask.Delay(100);
        Application.OpenURL(url);
        await UniTask.Delay(200); Application.OpenURL(url);
        
       // done = false;
    }
}
