using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WinLossRecMaker
{
    public partial class Form1 : Form
    {
        /// <summary>
        /// Display.txtを生成するための文字列
        /// </summary>
        private string _baseText = String.Empty;
        /// <summary>
        /// 書出し先
        /// </summary>
        private readonly string _fileName = "Display.txt";
        /// <summary>
        /// ファイルパス
        /// </summary>
        private string Path => System.IO.Path.Combine(Environment.CurrentDirectory, _fileName);
        public Form1()
        {
            InitializeComponent();
            _baseText = this._conversionText.Text;
            string result = GetDisplayText();
            WriteDispayText(result);
        }

        KeyboardHook keyboardHook = new KeyboardHook();
        /// <summary>
        /// イベントのアタッチ
        /// </summary>
        /// <param name="e"></param>
        protected override void OnLoad(EventArgs e)
        {
            keyboardHook.KeyDownEvent += KeyboardHook_KeyDownEvent;
            keyboardHook.Hook();
        }
        private NumericUpDown _preCtrl = null;
        /// <summary>
        /// グローバルキーイベントをフックしてキー操作を補足する。
        /// Display.txtを変更するのが目的
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void KeyboardHook_KeyDownEvent(object sender, KeyEventArg e)
        {
            if (this._chkInvalid.Checked)
            {
                return;
            }
            if (e.KeyCode == 49 || e.KeyCode == 38 || e.KeyCode == 97)
            {
                this._num1.Value++;
                _preCtrl = this._num1;
            }
            else if (e.KeyCode == 50 || e.KeyCode == 39 || e.KeyCode == 98)
            {
                this._num2.Value++;
                _preCtrl = this._num2;
            }
            else if (e.KeyCode == 8 && _preCtrl != null)
            {
                _preCtrl.Value--;
                _preCtrl = null;
            }
            else
            {
                return;
            }
            this.ChangeDisplayText();
        }
        /// <summary>
        /// Display.txtに書き込み
        /// </summary>
        /// <param name="result"></param>
        private void WriteDispayText(string result)
        {
            try
            {
                using (var sw = new StreamWriter(Path,false,Encoding.UTF8))
                {
                    sw.Write(result);
                }
            }
            catch (Exception)
            {
                MessageBox.Show("ファイルが他のアプリにより編集中となっています。", "エラー", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        /// <summary>
        /// Display.txtに表示する文字列を生成
        /// </summary>
        /// <returns></returns>
        private string GetDisplayText()
        {
            int changeTimes = 0;
            string result = String.Empty;
            for (int i = 0; i < _baseText.Length; i++)
            {
                if (_baseText[i] == '$')
                {
                    switch (changeTimes)
                    {
                        case 0:
                            result += this._num1.Value.ToString();
                            break;
                        case 1:
                            result += this._num2.Value.ToString();
                            break;
                    }
                    changeTimes++;
                }
                else
                {
                    result += _baseText[i];
                }
            }
            changeTimes = 0;
            return result;
        }
        /// <summary>
        /// キーイベントのアンフック
        /// </summary>
        /// <param name="e"></param>
        protected override void OnFormClosing(FormClosingEventArgs e)
        {
            keyboardHook.UnHook();
        }

        private void checkBox1_Click(object sender, EventArgs e)
        {
            if (this._chkInvalid.Checked)
            {
                this._chkInvalid.Text = "キー入力を有効化";
            }
            else
            {
                this._chkInvalid.Text = "キー入力を無効化";
            }
        }
        /// <summary>
        /// DisplayTextの構成要素が変化した時に実行されるイベント
        /// </summary>
        /// <param name="sender"></param>
        /// <param name="e"></param>
        private void RelatedTextChanged(object sender, EventArgs e)
        {
            ChangeDisplayText();
        }
        /// <summary>
        /// DisplayTextを変更
        /// </summary>
        private void ChangeDisplayText()
        {
            _baseText = this._conversionText.Text;
            string result = GetDisplayText();
            WriteDispayText(result);
        }
    }
}
