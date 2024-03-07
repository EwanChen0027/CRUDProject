namespace CRUDProject.Utility
{
    /// <summary>
    /// 整理環境變數, 並取得取得環境變數值
    /// </summary>
    public class EnvironmentHelper
    {
        private static string? enviromentVariable;

        public static string SetEnvorimentVariableAndGetValue(string? configEnv = null)
        {
            // 取得環境變數
            var serverEnv = Environment.GetEnvironmentVariable("ASPNETCORE_ENVIRONMENT");

            // 若無環境變數, 就用啟動時的參數設定
            if (string.IsNullOrWhiteSpace(serverEnv))
            {
                serverEnv = configEnv;

                // 如果都沒有值, defualt : dev
                if (string.IsNullOrWhiteSpace(serverEnv) || "Production".Equals(serverEnv, StringComparison.OrdinalIgnoreCase))
                    serverEnv = "dev";
            }

            enviromentVariable = serverEnv;
            return enviromentVariable;
        }
    }
}

