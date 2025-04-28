using System;
using Raylib_cs;

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

        while(!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(RAYWHITE); // 背景色指定．

            Raylib.DrawText("Hello, Donut Game!", 250, 280, 20, BLACK); // 文字列表示テスト．

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}