using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using CleverTap;
using CleverTap.Utilities;

using NotificationServices = UnityEngine.iOS.NotificationServices;
using NotificationType = UnityEngine.iOS.NotificationType;

public class CleverTapExample : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        #if (UNITY_IPHONE && !UNITY_EDITOR)
            OniOSStart();
        #endif
    }

    // Awake is called after all objects are initialized
    void Awake()
    {
    	NotificationServices.RegisterForNotifications( NotificationType.Alert | NotificationType.Badge | NotificationType.Sound);
    	#if (UNITY_IPHONE && !UNITY_EDITOR)
            OniOSInit();
        #endif
    }

    // Update is called once per frame
    void Update()
    {
        
    }

     void OniOSInit()
    {
        // register for push notificationssetUIEditorConnectionEnabled
        CleverTap.CleverTapBinding.RegisterPush();
        // set debug level
        CleverTapBinding.SetDebugLevel(4);
    }

     void OniOSStart()
    {
     // record basic event with no properties
        CleverTapBinding.RecordEvent("testEvent");
    }

}
