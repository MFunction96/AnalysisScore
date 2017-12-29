using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AnalysisScore.Properties;
using LinqToExcel;

namespace AnalysisScore.Controllers
{
    public class ExcelController
    {
        /// <summary>
        /// 
        /// </summary>
        private string[] Subjects { get; }
        /// <summary>
        /// 
        /// </summary>
        private ExcelQueryFactory Excel { get; }
        /// <summary>
        /// 
        /// </summary>
        public ExcelController(string filePath)
        {
            Subjects = new[]
            {
                Resources.Chinese,
                Resources.Math,
                Resources.English,
                Resources.Physics,
                Resources.Chemistry,
                Resources.Biology,
                Resources.Politics,
                Resources.History,
                Resources.Geography
            };
            Excel = new ExcelQueryFactory(filePath);
        }
        /// <summary>
        /// 
        /// </summary>
        /// <param name="columns"></param>
        /// <returns></returns>
        public Task<bool> Verify()
        {
            return Task.Run(() =>
            {
                var flag = false;
                var columns = QuerySheets();
                foreach (var subject in Subjects)
                {
                    flag = columns.Any(column =>
                        string.Equals(column, subject, StringComparison.CurrentCultureIgnoreCase));
                    if (flag) break;
                }
                return !flag;
            });
        }
        /// <summary>
        /// 
        /// </summary>
        public async Task Import()
        {
            var flag = await Verify();

        }
        /// <summary>
        /// 
        /// </summary>
        /// <returns></returns>
        public IEnumerable<string> QuerySheets()
        {
            return Excel.GetWorksheetNames();
        }
    }
}
