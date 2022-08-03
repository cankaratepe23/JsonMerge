using System;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;

namespace JsonMerge
{
    public partial class MainForm : Form
    {
        private enum JsonFileType
        {
            Original,
            Compare
        }

        private readonly Color _errorColor = Color.Red;
        private readonly Color _textColor = SystemColors.WindowText;

        private string _compareFilePath;
        private string _originalFilePath;

        public string OriginalFilePath
        {
            get => _originalFilePath;
            set
            {
                txtOriginalFilePath.Text = value;
                _originalFilePath = value;
            }
        }

        public string CompareFilePath
        {
            get => _compareFilePath;
            set
            {
                txtCompareFilePath.Text = value;
                _compareFilePath = value;
            }
        }

        public MainForm()
        {
            InitializeComponent();
        }

        private void RecalculateControlSizes()
        {
            pnlOriginalFile.Width = (this.Width / 2) - 30;
            pnlCompareFile.Width = (this.Width / 2) - 30;
            txtOriginalFilePath.Width = btnOriginalFileBrowse.Location.X - 14;
            txtCompareFilePath.Width = btnCompareFileBrowse.Location.X - 14;
        }

        private static void SetDragEventEffect(DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
            {
                e.Effect = DragDropEffects.Copy;
            }
        }

        private static string GetFilePathFromDragDrop(DragEventArgs e)
        {
            var files = e.Data.GetData(DataFormats.FileDrop) as string[];
            var file = files?.FirstOrDefault();
            return file;
        }

        private void HandlePathChange(string path, JsonFileType type)
        {
            if (type == JsonFileType.Original)
            {
                OriginalFilePath = path;
            }
            else
            {
                CompareFilePath = path;
            }
        }

        private bool IsBothPathsValid()
        {
            var origPathIsValid = txtOriginalFilePath.Tag != null && (bool)txtOriginalFilePath.Tag;
            var compPathIsValid = txtCompareFilePath.Tag != null && (bool)txtCompareFilePath.Tag;
            return origPathIsValid && compPathIsValid;
        }

        private void pnl_DragDrop(object sender, DragEventArgs e)
        {
            if (!(sender is Panel senderPanel)) return;
            TextBox senderBox = null;
            var filePath = GetFilePathFromDragDrop(e);

            HandlePathChange(filePath,
                senderPanel.Equals(pnlOriginalFile) ? JsonFileType.Original : JsonFileType.Compare);

            // TODO Load the files and compare etc.
        }

        private void TextBox_TextChanged(object sender, EventArgs e)
        {
            if (!(sender is TextBox targetBox)) return;
            var path = targetBox.Text;
            var isValid = !string.IsNullOrWhiteSpace(path) && File.Exists(path);

            targetBox.Tag = isValid;
            targetBox.ForeColor = isValid ? _textColor : _errorColor;
            btnCompareFiles.Enabled = IsBothPathsValid();
        }

        private void TextBoxPath_Leave(object sender, EventArgs e)
        {
            if (!(sender is TextBox targetBox)) return;
            var path = targetBox.Text;

            HandlePathChange(path,
                targetBox.Equals(txtOriginalFilePath) ? JsonFileType.Original : JsonFileType.Compare);
        }

        private void MainForm_SizeChanged(object sender, EventArgs e)
        {
            RecalculateControlSizes();
        }

        private void MainForm_Load(object sender, EventArgs e)
        {
            RecalculateControlSizes();

        }

        private void Panel_DragEnter(object sender, DragEventArgs e)
        {
            SetDragEventEffect(e);
        }

        private void btnOriginalFileBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = openFileDialog.FileName;
            OriginalFilePath = filePath;
        }

        private void btnCompareFileBrowse_Click(object sender, EventArgs e)
        {
            if (openFileDialog.ShowDialog() != DialogResult.OK) return;

            var filePath = openFileDialog.FileName;
            CompareFilePath = filePath;
        }
    }
}