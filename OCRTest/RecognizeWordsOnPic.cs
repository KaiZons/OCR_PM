using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Configuration;
using BaiduAIAPI;
using System.IO;
using ImageMoveZoom;
using System.Web;
using Utilities;
using Module;

namespace OCRTest
{
    public partial class RecognizeWordsOnPic : Form
    {
        public RecognizeWordsOnPic()
        {
            InitializeComponent();
            m_recognizeButton.Enabled = false;
        }

        //选择图片
        private void OnSelectPictureButtonClick(object sender, EventArgs e)
        {
            try
            {
                using (OpenFileDialog picDlg = new OpenFileDialog())
                {
                    picDlg.InitialDirectory = Environment.GetFolderPath(Environment.SpecialFolder.Desktop);
                    picDlg.Filter = "图片|*.bmp;*.ico;*.jpeg;*.jpg;*.png;*.tif;*.tiff";
                    picDlg.RestoreDirectory = true;
                    picDlg.FilterIndex = 1;
                    if (picDlg.ShowDialog() == System.Windows.Forms.DialogResult.OK)
                    {
                        m_imagePathText.Text = picDlg.FileName;
                        FileStream fileImage = new FileStream(picDlg.FileName, FileMode.Open, FileAccess.Read);
                        Image image = Image.FromStream(fileImage);
                        if (image != null)
                        {
                            m_originalPictureBox.Image = image;
                            m_recognizeButton.Enabled = true;
                        }
                    }
                }
            }
            catch (Exception ex)
            {

            }
        }

        //双击预览图片
        private void pictureBox_DoubleClick(object sender, EventArgs e)
        {
            if (m_originalPictureBox.Image == null)
            {
                return;
            }
            using (PicViewForm picView = new PicViewForm())
            {
                picView.InPutBuffer(m_originalPictureBox.Image);
                picView.ShowDialog();
            }
        }

        //识别文字
        private void OnRecognizeButtonClick(object sender, EventArgs e)
        {
            if (m_originalPictureBox.Image == null)
            {
                return;
            }
            AccessTokenView token = AccessToken.GetAccessToken();
            if (!token.IsSuccess)
            {
                MessageBox.Show("获取Token失败！", "提示", MessageBoxButtons.OK, MessageBoxIcon.Information);
                return;
            }
            string text = RecognizeText(token.SuccessModel.access_token);
            m_resultTextBox.Text = text;
        }

        private string RecognizeText(string tokenString)
        {
            string host = "https://aip.baidubce.com/rest/2.0/ocr/v1/accurate_basic?access_token=" + tokenString;//参数参考https://ai.baidu.com/docs#/OCR-API/top
            Bitmap bitmap = new Bitmap(m_originalPictureBox.Image);
            string imageByteValue = ImageConversion.ImageToByte64String(bitmap, System.Drawing.Imaging.ImageFormat.Jpeg);
            string requestParas = "detect_direction=" + false + "&image=" + HttpUtility.UrlEncode(imageByteValue);
            string result = HttpRequestHelper.Post(host, requestParas);
            RecognizeResultModel recognizeResult = JsonExtends.ToObject<RecognizeResultModel>(result);
            string[] wordArray = recognizeResult.words_result.Select(a => a.words).ToArray();
            return string.Join("\r\n", wordArray);
        }
    }
}
