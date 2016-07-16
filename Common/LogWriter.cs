using System;
using System.Collections.Generic;
using System.Configuration;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Common
{
    public class LogWriter
    {
        private string _FullPath;

        /// <summary>
        /// AppSetting的LogPath
        /// </summary>
        private string _LogPath = ConfigurationManager.AppSettings["LogPath"];

        /// <summary>
        /// 初始化
        /// </summary>
        /// <param name="filename">檔名</param>
        public LogWriter(string filename)
        {
            if (!Directory.Exists(_LogPath))//如果沒有此資料夾
                Directory.CreateDirectory(_LogPath);//就創建它
            _FullPath = _LogPath + "\\" + filename + ".log";
        }

        public void WriteErrorLog(string content, Exception ex)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("時間:" + DateTime.Now.ToLongDateString());
            sb.AppendLine("錯誤內容:" + content);
            sb.AppendLine("錯誤代碼:" + ex.ToString());
            sb.AppendLine("======================================");
            File.WriteAllText(_FullPath, sb.ToString());
        }

        public void WriteLog(string content)
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("時間:" + DateTime.Now.ToLongDateString());
            sb.AppendLine("內容:" + content);
            sb.AppendLine("======================================");
            File.WriteAllText(_FullPath, sb.ToString());
        }
    }
}