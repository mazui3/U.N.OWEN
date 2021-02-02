using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class AudioScript : MonoBehaviour
{
    public float volRecord;

    private static AudioScript instance = null;
    public static AudioScript Instance
    {
        get { return instance; }
    }

    private void Awake()
    {
        if (instance != null)
        {
            VolumeChanger.SetOldVol(instance.volRecord);
        }

        if (instance != null && instance != this)
        {
            Destroy(this.gameObject);
            return;
        }
        else
        {
            instance = this;
        }
        DontDestroyOnLoad(this.gameObject);
    }

    void Update()
    {
        volRecord = VolumeChanger.GetOldVol();
    }

    public static void SetInstance()
    {
        instance = null;
    }


}
