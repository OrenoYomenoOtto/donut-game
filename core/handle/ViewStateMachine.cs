using System;
using Raylib_cs;
using donut.core.view;
using donut.core.view.titleView;
using System.Reflection.Metadata;

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
    private GamePhase State;

    private GameView Game;

    public ViewStateMachine()
    {
        this.Game = new GameView();

        // this.mState = GamePhase.E_TITLE;
        this.State = GamePhase.E_GAME;
    }

    // 現在ステートがE_ENDなら真を返す
    public bool isStateEnd()
    {
        return this.State == GamePhase.E_END;
    }

    public void StateProcess()
    {
        switch (this.State)
        {
            case GamePhase.E_END:
                // 処理なし
                break;
            case GamePhase.E_TITLE:
                // title.TitleDraw();
                break;
            case GamePhase.E_GAME:
                this.State = this.Game.GameDraw();
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
    }
}