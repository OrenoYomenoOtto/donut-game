using System;
using Raylib_cs;
using donut.core.view;
using donut.core.view.titleView;

namespace donut.core.handle;

public enum GamePhase
{
    E_END,
    E_TITLE,
    E_GAME,
    E_RESULT,
    E_RANKING,
    E_HOW_TO_PLAY,
}

class ViewStateMachine
{
    // 描画用色定義
    static readonly Color RAYWHITE = new Color(245, 245, 245, 255);  // 公式のRAYWHITE相当
    static readonly Color BLACK = new Color(0, 0, 0, 255);
    static readonly int FPS = 60; // フレームレート設定.

    private GamePhase mState;

    private GameView mGame;

    public ViewStateMachine()
    {
        this.mGame = new GameView();
        
        // this.mState = GamePhase.E_TITLE;
        this.mState = GamePhase.E_GAME;
    }

    public void StateProccess()
    {
        switch (this.mState)
        {
            case GamePhase.E_END:
                Raylib.WindowShouldClose();
                break;
            case GamePhase.E_TITLE:
                // title.TitleDraw();
                break;
            case GamePhase.E_GAME:
                this.mState = this.mGame.GameDraw();
                break;
            case GamePhase.E_RESULT:
                // this.mState = result.ResultDraw();
                break;
            case GamePhase.E_RANKING:
                // this.mState = ranking.RankingDraw();
                break;
            case GamePhase.E_HOW_TO_PLAY:
                // this.mState = houto.HowToPlayDraw();
                break;
        }
        Raylib.EndDrawing();


        Raylib.CloseWindow();
    }
}