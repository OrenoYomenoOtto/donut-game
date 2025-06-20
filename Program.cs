using System;
using Raylib_cs;

using donut.core.handle;
using donut.core.view;

class Donut
{
    // 描画用色定義
    static readonly Color RAYWHITE = new Color(245, 245, 245, 255);  // 公式のRAYWHITE相当
    static readonly Color BLACK = new Color(0, 0, 0, 255);
    static readonly int FPS = 60; // フレームレート設定.

    static void Main()
    {
        // 後々初期化処理は関数化します．
        Raylib.InitWindow(800, 600, "ドーナツゲーム🍩"); // 画面サイズ，ウィンドウタイトルの設定．
        Raylib.SetTargetFPS(FPS);

        ViewStateMachine stateMachine = new ViewStateMachine();
        while (!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(RAYWHITE); // 画面クリア

            // 現在ステートに対応する処理を実行
            stateMachine.StateProccess();

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}