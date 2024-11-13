using Common.Scene;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Title : BaseSceneUI
{

    public void NextScene()
    {
        SceneManagerEx.LoadingAndNextScene(SceneType.InGame);
    }
}
