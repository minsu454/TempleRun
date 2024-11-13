using Common.Scene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InGame : BaseSceneUI
{
    public void CreatePopup()
    {
        Managers.UI.CreatePopup<GameOverPopup>();
    }

    public void NextScene()
    {
        SceneManagerEx.LoadingAndNextScene(SceneType.Title);
    }
}
