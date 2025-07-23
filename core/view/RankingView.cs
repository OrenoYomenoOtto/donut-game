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
    /// ランキング画面を描画します
    /// </summary>
    /// <returns>現在のゲームフェーズ（E_RANKING）</returns>
    public GamePhase RankingDraw()
    {
        Raylib.ClearBackground(Color.RayWhite);

        Raylib.DrawText("Ranking", 350, 50, 20, Color.Black);
        for (int i = 0; i < RankingScores.Count; i++)
        {
            DrawRankingScore(RankingScores[i], i);
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

    /// <summary>
    /// RankingViewのデストラクタ
    /// </summary>
    ~RankingView()
    {
    }
}
