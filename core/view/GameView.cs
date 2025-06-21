using System;
using Raylib_cs;
using donut.core.handle;
using System.Reflection.Metadata;

namespace donut.core.view;

public class GameView
{
    const int DONUT_PIX = 64;

    const int DRAW_AREA_X_BEGIN = 71;
    const int DRAW_AREA_X_END = DRAW_AREA_X_BEGIN + DONUT_PIX * 7;
    const int DRAW_AREA_Y_BEGIN = 132;
    const int DRAW_AREA_Y_END = DRAW_AREA_Y_BEGIN + DONUT_PIX * 6;

    static readonly Color BLACK = new Color(0, 0, 0, 255);
    
    static readonly Color WHITE = new Color(255, 255, 255, 255);

    private Texture2D backgroundTexture;

    public GameView()
    {
        backgroundTexture = Raylib.LoadTextureFromImage(Raylib.LoadImage("assets/images/GameViewBack.png"));
    }

    ~GameView()
    {

    }

    // 現在ステートがE_GAMEの時に毎フレーム呼ばれる関数
    public GamePhase GameDraw()
    {
        Raylib.DrawTexture(backgroundTexture, 0, 0, WHITE);
        this.DrawGrid();
        return GamePhase.E_GAME;
    }

    private void GameStart()
    {

    }

    private void DrawGrid()
    {
        for (int x = DRAW_AREA_X_BEGIN; x <= DRAW_AREA_X_END; x += DONUT_PIX)
        {
            Raylib.DrawLine(x, DRAW_AREA_Y_BEGIN, x, DRAW_AREA_Y_END, BLACK);
        }
        for (int y = DRAW_AREA_Y_BEGIN; y <= DRAW_AREA_Y_END; y += DONUT_PIX)
        {
            Raylib.DrawLine(DRAW_AREA_X_BEGIN, y, DRAW_AREA_X_END, y, BLACK);
        }
    }
}
