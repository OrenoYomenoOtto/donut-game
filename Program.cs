using System;
using Raylib_cs;

class Donut
{
    static void Main()
    {
        Raylib.InitWindow(800, 600, "ドーナツゲーム🍩");
        Raylib.SetTargetFPS(60);

        Color RAYWHITE = new Color(245, 245, 245, 255);  // 公式のRAYWHITE相当
        Color BLACK = new Color(0, 0, 0, 255);

        while(!Raylib.WindowShouldClose())
        {
            Raylib.BeginDrawing();
            Raylib.ClearBackground(RAYWHITE);

            Raylib.DrawText("Hello, Donut Game!", 250, 280, 20, BLACK);

            Raylib.EndDrawing();
        }

        Raylib.CloseWindow();
    }
}