using System;
using Raylib_cs;
using donut.core.handle;

namespace donut.core.view;

public class GameView
{
    static readonly Color BLACK = new Color(0, 0, 0, 255);
    public GameView()
    {

    }

    ~GameView()
    {

    }

    // 現在ステートがE_GAMEの時に毎フレーム呼ばれる関数
    public GamePhase GameDraw()
    {
        this.GameInit();
        return GamePhase.E_GAME;
    }

    // 何かを初期化
    private void GameInit()
    {
        this.DrawGrid();
    }

    private void GameStart()
    {

    }

    private void DrawGrid()
    {
        for (int x = 0; x < 800; x += 100)
        {
            Raylib.DrawLine(x, 0, x, 600, BLACK);
        }
        for (int y = 0; y < 600; y += 100)
        {
            Raylib.DrawLine(0, y, 800, y, BLACK);
        }
    }
}
