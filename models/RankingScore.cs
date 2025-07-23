/// <summary>
/// プレイヤーのランキングスコアを表します。プレイヤー名とスコアを含みます。
/// </summary>
/// <param name="playerName">プレイヤーの名前。</param>
/// <param name="score">プレイヤーが獲得したスコア。</param>
public class RankingScore(string playerName, int score)
{
    public string PlayerName { get; set; } = playerName;
    public int Score { get; set; } = score;
}