using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundManagerScript : MonoBehaviour
{

    public static AudioClip coinSound;
    static AudioSource audiosrc;
    // Start is called before the first frame update
    void Awake()
    {
        coinSound = Resources.Load<AudioClip>("coin1");
        audiosrc = GetComponent<AudioSource>();
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public static void PlaySound (string clip)
    {
        switch (clip)
        {
            case "coin":
                audiosrc.PlayOneShot(coinSound);
                break;

        }

    }
}
