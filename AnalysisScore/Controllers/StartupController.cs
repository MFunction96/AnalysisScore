using AnalysisScore.Data;

namespace AnalysisScore.Controllers
{
    /// <summary>
    /// 
    /// </summary>
    public class StartupController
    {
        /// <summary>
        /// 
        /// </summary>
        public OracleDbContext Context => new OracleDbContext();
    }
}
