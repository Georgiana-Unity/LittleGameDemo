using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SoundController : MonoBehaviour {
    public AudioClip clickSound, coinSCollectrSound, fireSound, jumpSound, bullet1, bullet2, bullet3, bullet4, laserFireSound, enemyDead;
    public static SoundController _instance;
    public AudioSource[] audioSources;
	// Use this for initialization
	void Awake () {
        _instance = this;
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    public void PlayCoinsCollectSound(){ SwitchAudioSources(coinSCollectrSound); }
    public void PlayJumpSound(){ SwitchAudioSources(jumpSound); }
    public void PlayEnemyDeadSound(){ SwitchAudioSources(enemyDead); }
    public void PlayBullet1Sound(){ SwitchAudioSources(bullet1); }
    public void PlayBullet2Sound(){ SwitchAudioSources(bullet2); }
    public void PlayBullet3Sound(){ SwitchAudioSources(bullet3); }
    public void PlayBullet4Sound(){ SwitchAudioSources(bullet4); }
    public void PlayFireSound(){ SwitchAudioSources(fireSound); }
    public void PlayClickSound(){ SwitchAudioSources(clickSound); }
    public void PlayLaseFireSound() { SwitchAudioSources(laserFireSound); }
    void SwitchAudioSources(AudioClip clip)
    {
        if (audioSources[0].isPlaying)
        {
            audioSources[1].PlayOneShot(clip);
        }
        else
        {
            audioSources[0].PlayOneShot(clip);
        }
    }
}
