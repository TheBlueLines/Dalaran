using System.Drawing.Drawing2D;
using System.Drawing.Imaging;

namespace Dalaran
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        private void open_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "All files (*.*)|*.*",
                FilterIndex = 0
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                byte[] bytes = File.ReadAllBytes(openFileDialog.FileName);
                int magic = (int)Math.Ceiling(Math.Sqrt(bytes.Length));
                Bitmap image = new Bitmap(magic, magic);
                for (int i = 0; i < bytes.Length; i++)
                {
                    byte b = bytes[i];
                    image.SetPixel(i % magic, (int)i / magic, Color.FromArgb(b, b, b));
                }
                picture.Image = image;
            }
        }

        private void picture_Paint(object sender, PaintEventArgs e)
        {
            if (picture.Image != null)
            {
                e.Graphics.InterpolationMode = InterpolationMode.NearestNeighbor;
                e.Graphics.PixelOffsetMode = PixelOffsetMode.Half;
                e.Graphics.DrawImage(picture.Image, new Rectangle(0, 0, picture.Width, picture.Height), 0, 0, picture.Image.Width, picture.Image.Height, GraphicsUnit.Pixel);
            }
        }
        private void save_Click(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                SaveFileDialog saveFileDialog = new()
                {
                    Filter = "PNG (*.png)|*.png|All files (*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    picture.Image.Save(saveFileDialog.FileName, ImageFormat.Png);
                }
            }
        }
        private void file_Click(object sender, EventArgs e)
        {
            if (picture.Image != null)
            {
                List<byte> bytes = new();
                SaveFileDialog saveFileDialog = new()
                {
                    Filter = "All files (*.*)|*.*",
                    FilterIndex = 1,
                    RestoreDirectory = true,
                };
                if (saveFileDialog.ShowDialog() == DialogResult.OK)
                {
                    Bitmap bitmap = new(picture.Image);
                    for (int i = 0; i < bitmap.Height; i++)
                    {
                        for (int j = 0; j < bitmap.Width; j++)
                        {
                            Color color = bitmap.GetPixel(j, i);
                            if (color.A == byte.MaxValue && color.R == color.G && color.R == color.B)
                            {
                                bytes.Add(color.B);
                            }
                        }
                    }
                    File.WriteAllBytes(saveFileDialog.FileName, bytes.ToArray());
                }
            }
        }
        private void nzx_Click(object sender, EventArgs e)
        {
            OpenFileDialog openFileDialog = new()
            {
                Filter = "All files (*.*)|*.*",
                FilterIndex = 0
            };
            if (openFileDialog.ShowDialog() == DialogResult.OK)
            {
                picture.Image = Image.FromFile(openFileDialog.FileName);
            }
        }
    }
}