using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrebidWrapper : MonoBehaviour
{
    private AndroidJavaObject myLibrary;

    private void Start()
    {
        PrebidInit();
    }
    
    private void PrebidInit()
    {
        AndroidJavaObject currentActivity = new AndroidJavaClass("com.unity3d.player.UnityPlayer").GetStatic<AndroidJavaObject>("currentActivity");
        myLibrary = new AndroidJavaObject("com.appswim.prebid.mobile.CustomApplication", currentActivity);

        myLibrary.Call("initPrebidMy");
    }

}
