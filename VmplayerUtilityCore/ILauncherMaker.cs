namespace VmplayerUtilityCore
{
    /// <summary>
    /// ランチャー作成用クラスのインターフェース
    /// </summary>
    /// <remarks>OS間の差異を吸収する。</remarks>
    public interface ILauncherMaker
    {
        /// <summary>
        /// ランチャーを作成する
        /// </summary>
        /// <param name="command">実行対象のコマンド</param>
        /// <param name="shortcutFile">ランチャーのフルパス。拡張子はつけない。</param>
        void MakeLauncher(string command, string args, string launcherPath);
    }
}
