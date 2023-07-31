using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using System.Diagnostics;

namespace PythonCall
{
    public partial class MainWindow : Form
    {
        public MainWindow()
        {
            InitializeComponent();

            PythonScript();
        }

        private void uxExec_Click(object sender, EventArgs e)
        {
            //Pythonプログラムソースをファイルに保存
            File.WriteAllText(uxPath.Text, uxPythonSource.Text, Encoding.GetEncoding("utf-8"));

            //Pythonプログラムのパスとプログラムに渡す引数を準備
            string program = uxPath.Text;
            string param = uxMesssage.Text + " " + uxCount.Text;

            //Pythonプログラムを実行し、戻ってきた結果をテキストボックスに出力
            foreach(string line in PythonCall(program,param))
            {
                uxResult.AppendText(line);
            }
        }

        /// <summary>
        /// プロセスの実行
        /// </summary>
        /// <param name="filename"></param>
        /// <param name="args"></param>
        /// <returns></returns>
        public IEnumerable<string> PythonCall(string program,string args = "1000")
        {
            ProcessStartInfo psInfo = new ProcessStartInfo();

            // 実行するファイルをセット
            psInfo.FileName = "Python";

            //引数があればセット
            psInfo.Arguments = string.Format("\"{0}\" {1}", program, args);

            // コンソール・ウィンドウを開かない
            psInfo.CreateNoWindow = true;

            // シェル機能を使用しない
            psInfo.UseShellExecute = false;

            // 標準出力をリダイレクトする
            psInfo.RedirectStandardOutput = true;

            // プロセスを開始
            Process p = Process.Start(psInfo); 

            // アプリのコンソール出力結果を全て受け取る
            string line = null;
            while ((line = p.StandardOutput.ReadLine()) != null)
            {
                yield return line + Environment.NewLine;
            }
        }

        private void PythonScript()
        {
            StringBuilder sb = new StringBuilder();
            sb.AppendLine("import sys");
            sb.AppendLine("");
            sb.AppendLine("argvs = sys.argv");
            sb.AppendLine("message = argvs[1]");
            sb.AppendLine("count = int(argvs[2])");
            sb.AppendLine("");
            sb.AppendLine("print('開始')");
            sb.AppendLine("");
            sb.AppendLine("for i in range(count):");
            sb.AppendLine("  print('{0} {1}'.format(message,i))");
            sb.AppendLine("");
            sb.AppendLine("print('完了')");

            uxPythonSource.Text = sb.ToString();
        }

    }
}
