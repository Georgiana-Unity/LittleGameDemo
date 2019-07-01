using DG.Tweening;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEngine.UI;


public class MainMenuController : MonoBehaviour {
    public static MainMenuController _instance;
    public SoundController sound;
    private GameObject uibg, mainPanel, infoPanel, shopPanel, settingPanel;
    private Button play_M, info_M, shop_M, setting_M,back_I,buy1,buy2,buy3,buy4,buy5,buy6,back_S,back_E,exit_E;
    
    private void Awake()
    {
        _instance = this;
        sound = GetComponent<SoundController>();
        uibg = GameObject.FindGameObjectWithTag("UIBg");
        mainPanel = uibg.transform.Find("Main").gameObject;
        infoPanel = uibg.transform.Find("Info").gameObject;
        shopPanel = uibg.transform.Find("Shop").gameObject;
        settingPanel = uibg.transform.Find("Setting").gameObject;
        play_M = mainPanel.transform.Find("play").GetComponent<Button>();
        play_M.onClick.AddListener(sound.PlayClickSound);
        play_M.onClick.AddListener(()=>SceneManager.LoadScene("Game"));

        info_M = mainPanel.transform.Find("info").GetComponent<Button>();
        info_M.onClick.AddListener(sound.PlayClickSound);
        info_M.onClick.AddListener(ShowInfo);

        shop_M = mainPanel.transform.Find("shop").GetComponent<Button>();
        shop_M.onClick.AddListener(sound.PlayClickSound);
        shop_M.onClick.AddListener(ShowShop);

        setting_M = mainPanel.transform.Find("exit").GetComponent<Button>();
        setting_M.onClick.AddListener(sound.PlayClickSound);
        setting_M.onClick.AddListener(ShowSetting);

        back_I = infoPanel.transform.Find("back").GetComponent<Button>();
        back_I.onClick.AddListener(sound.PlayClickSound);
        back_I.onClick.AddListener(InfoBack);

        back_S = shopPanel.transform.Find("bg3/back").GetComponent<Button>();
        back_S.onClick.AddListener(sound.PlayClickSound);
        back_S.onClick.AddListener(ShopBack);

        back_E = settingPanel.transform.Find("back").GetComponent<Button>();
        back_E.onClick.AddListener(sound.PlayClickSound);
        back_E.onClick.AddListener(SettingBack);

    }
    // Use this for initialization
    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {
		
	}
    void HideMainPanel()
    {
        mainPanel.SetActive(false);
    }
    IEnumerator ShowMainPanel()
    {
        yield return new WaitForSeconds(0.4f);
        mainPanel.SetActive(true);
    }
    void ShowInfo()
    {
        HideMainPanel();
        infoPanel.transform.DOLocalMoveX(-29f,0.5f);
    }
    void ShowShop()
    {
        HideMainPanel();
        shopPanel.transform.DOLocalMoveY(0f, 0.5f);
    }
    void ShowSetting()
    {
        HideMainPanel();
        settingPanel.transform.DOLocalMoveX(-29f, 0.5f);
    }
    void InfoBack()
    {
        infoPanel.transform.DOLocalMoveX(-1022f, 0.5f);
        StartCoroutine(ShowMainPanel());
    }
    void ShopBack()
    {
        shopPanel.transform.DOLocalMoveY(667f, 0.5f);
        StartCoroutine(ShowMainPanel());
    }
    void SettingBack()
    {
        settingPanel.transform.DOLocalMoveX(1045f, 0.5f);
        StartCoroutine(ShowMainPanel());
    }
}
