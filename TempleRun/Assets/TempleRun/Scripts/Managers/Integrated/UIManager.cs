using System;
using System.Collections.Generic;
using System.Linq;
using Unity.VisualScripting;
using UnityEngine;
using UnityEngine.SceneManagement;

public sealed class UIManager : MonoBehaviour, IManager
{
    private readonly List<BasePopupUI> showList = new List<BasePopupUI>();

    public void Init()
    {
        SceneManager.sceneLoaded += OnSceneLoaded;
    }

    public void OnSceneLoaded(Scene scene, LoadSceneMode mode)
    {
        showList.Clear();
        CreateSceneUI(scene.name);
    }

    private void CreateSceneUI(string name)
    {
        GameObject prefab = Resources.Load<GameObject>(name);      //추후 수정

        if (prefab == null)
        {
            Debug.LogError($"Is Not Prefab Resources Forder : {name}");
            return;
        }

        GameObject cloneGo = Instantiate(prefab);
        BaseSceneUI sceneUI = cloneGo.GetComponent<BaseSceneUI>();

        sceneUI.Init();
    }

    public void CreatePopup<T>(PopupOption option = null) where T : BasePopupUI
    {
        GameObject prefab = Resources.Load<GameObject>(typeof(T).Name);      //추후 수정

        if (prefab == null)
        {
            Debug.LogError($"Is Not Prefab Resources Forder : {name}");
            return;
        }

        GameObject cloneGo = Instantiate(prefab);

        T popupUI = cloneGo.GetComponent<T>();
        showList.Add(popupUI);

        popupUI.Init(option);
    }

    public void ClosePopup()
    {
        if (showList.Count == 0)
            return;

        BasePopupUI popup = showList[showList.Count - 1];
        Destroy(popup.gameObject);

        showList.RemoveAt(showList.Count - 1);
    }

    public void ClosePopup<T>(T popup) where T : BasePopupUI
    {
        int idx = showList.Count - 1;

        while (idx == 0)
        {
            if (showList[idx] == popup)
                break;

            idx--;
        }

        if (idx == -1)
            Debug.LogError($"Is Not Found Popup : {typeof(T).Name}");

        Destroy(popup.gameObject);
        showList.RemoveAt(idx);
    }
}
