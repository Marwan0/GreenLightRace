﻿using UnityEngine.UI;

public class GuiLobbyItem : UnityEngine.MonoBehaviour
{
    public Graphic selfGraphic;
    public Button readyToggleButton;
    public Text textPlayerName;
    public Text textPlayerPing;
    public Button kickButton;

    public NetworkPlayerNoir player;
    public UnityEngine.Color32 colorReady;
    public UnityEngine.Color32 colorNotReady;
}
