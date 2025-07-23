using donut.core.handle;
using Raylib_cs;

namespace donut.core.view.rankingView;

/// <summary>
/// ランキング画面の表示を担当するビュークラス
/// </summary>
/// <param name="rankingScores">表示するランキングスコアのリスト</param>
public class RankingView(List<RankingScore> rankingScores)
{
    /// <summary>
    /// ランキングスコアのリストを取得または設定します
    /// </summary>
    public List<RankingScore> RankingScores { get; set; } = rankingScores;

    /// <summary>
    /// 戻るボタンのX座標
    /// </summary>
    readonly int backButtonX = 100;

    /// <summary>
    /// 戻るボタンのY座標
    /// </summary>
    readonly int backButtonY = 400;

    /// <summary>
    /// 戻るボタンの幅
    /// </summary>
    readonly int backButtonWidth = 100;

    /// <summary>
    /// 戻るボタンの高さ
    /// </summary>
    readonly int backButtonHeight = 40;

    /// <summary>
    /// ランキング画面を描画します
    /// </summary>
    /// <returns>
    /// 描画後のゲームフェーズを返します
    /// </returns>
    public GamePhase RankingDraw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("Ranking", 350, 50, 20, Color.Black);
        for (int i = 0; i < RankingScores.Count; i++)
        {
            DrawRankingScore(RankingScores[i], i);
        }

        // 戻るボタンの描画とクリック処理
        // 画面の左上に「Back」と表示し、クリックでタイトル画面に戻る処理を追加
        float mousePositionX = Raylib.GetMousePosition().X;
        float mousePositionY = Raylib.GetMousePosition().Y;

        bool isMouseOverBackButton = mousePositionX >= backButtonX
            && mousePositionX <= backButtonX + backButtonWidth
            && mousePositionY >= backButtonY
            && mousePositionY <= backButtonY + backButtonHeight;

        if (isMouseOverBackButton)
        {
            Raylib.DrawRectangle(backButtonX, backButtonY, backButtonWidth, backButtonHeight, Color.LightGray);
            Raylib.DrawText("Back", backButtonX + 20, backButtonY + 10, 20, Color.Black);
        }
        else
        {
            Raylib.DrawRectangle(backButtonX, backButtonY, backButtonWidth, backButtonHeight, Color.Gray);
            Raylib.DrawText("Back", backButtonX + 20, backButtonY + 10, 20, Color.White);
        }
        if (Raylib.IsMouseButtonPressed(MouseButton.Left) && isMouseOverBackButton)
        {
            return GamePhase.E_TITLE;
        }

        return GamePhase.E_RANKING;
    }

    /// <summary>
    /// 個別のランキングスコアを描画します
    /// </summary>
    /// <param name="score">描画するランキングスコア</param>
    /// <param name="index">ランキングのインデックス（0から開始）</param>
    public void DrawRankingScore(RankingScore score, int index)
    {
        Raylib.DrawText($"{index + 1}. {score.PlayerName}", 150, 100 + index * 60, 20, Color.Black);
        Raylib.DrawText($"{score.Score}", 200, 130 + index * 60, 20, Color.Black);
    }
}
