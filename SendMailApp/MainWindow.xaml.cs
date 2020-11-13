using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Net;
using System.Net.Mail;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace SendMailApp
{
    /// <summary>
    /// MainWindow.xaml の相互作用ロジック
    /// </summary>
    public partial class MainWindow : Window
    {
        SmtpClient sc = new SmtpClient();

        public MainWindow()
        {
            InitializeComponent();
            sc.SendCompleted += Sc_SendCompleted;
        }

        //完了イベント
        private void Sc_SendCompleted(object sender, System.ComponentModel.AsyncCompletedEventArgs e)
        {
            if (e.Cancelled)
            {
                MessageBox.Show("送信キャンセルされました。");
            }
            else
            {
                MessageBox.Show(e.Error?.Message ?? "送信完了！");
            }
        }

        //メール送信処理
        private void btSend_Click(object sender, RoutedEventArgs e)
        {
            try
            {
                Config ctf = Config.GetInstance();
                MailMessage msg = new MailMessage(ctf.MailAddress , tbTo.Text);
                if (tbCc.Text != "")
                {
                    msg.CC.Add(tbCc.Text);
                }
                else if (tbBcc.Text != "")
                {
                    msg.Bcc.Add(tbBcc.Text);
                }
                msg.Subject = tbTitle.Text; //件名
                msg.Body = tbBody.Text; //本文

                
                sc.Host = ctf.Smtp; //SMTPサーバの設定
                sc.Port = ctf.Port;
                sc.EnableSsl = ctf.Ssl;
                sc.Credentials = new NetworkCredential(ctf.MailAddress , ctf.PassWord);

                //sc.Send(msg);   //送信
                sc.SendMailAsync(msg);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        //送信キャンセル処理
        private void btCancel_Click(object sender, RoutedEventArgs e)
        {
            sc.SendAsyncCancel();
        }

        //設定ボタンイベントハンドラ
        private void btConfig_Click(object sender, RoutedEventArgs e)
        {
            ConfigWindowShow(); //設定画面表示
        }

        //設定画面表示
        private void ConfigWindowShow()
        {
            ConfigWindow configWindow = new ConfigWindow(); //設定画面のインスタンスを生成
            configWindow.Show();  //表示
        }


        //メインウィンドウがロードされるタイミングで呼び出される
        private void Window_Loaded(object sender, RoutedEventArgs e)
        {
            try
            {
                Config.GetInstance().DeSerialise(); //逆シリアル化　XML→オブジェクト

            }
            catch (FileNotFoundException)
            {
                //btConfig_Click(sender, e);
                ConfigWindowShow(); //ファイルが存在しないので設定画面を先に生成
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }


        private void Window_Closed(object sender, EventArgs e)
        {
            try
            {
                Config.GetInstance().Serialise();   //シリアル化　オブジェクト→XML
            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void tbAdd_Click(object sender, RoutedEventArgs e)
        {
            var fod = new OpenFileDialog();
            fod.Multiselect = true;
            if (fod.ShowDialog() == true)
            {
                lbfile.Items.Add(fod.FileName);
                //lbfile.SelectedItems.Add(fod.FileNames);
                //lbfile.SelectedItems.Add(fod.Multiselect);
            }
        }

        private void tbDelete_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}
