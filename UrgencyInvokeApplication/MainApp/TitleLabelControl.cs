using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Reactive;
using System.Reactive.Linq;
using System.Reactive.Subjects;
using System.Windows.Forms;
using UrgencyInvokeApp.Properties;

namespace MainApp
{
    public partial class TitleLabelControl : UserControl
    {
        private readonly BehaviorSubject<bool> _expandedSubject = new BehaviorSubject<bool>(false);
        private readonly Subject<Unit> _titleClickSubject = new Subject<Unit>();
        private readonly Bitmap _resizedExpandBtnImage_0;
        private readonly Bitmap _resizedExpandBtnImage_90;
        
        public IObservable<bool> ExpandChangedObservable => _expandedSubject.AsObservable();
        public IObservable<Unit> TitleClickObservable => _titleClickSubject.AsObservable();

        public TitleLabelControl()
        {
            InitializeComponent();
            _resizedExpandBtnImage_0 = BitmapCreator.Create_0(_expandBtnPicture);
            _resizedExpandBtnImage_90 = BitmapCreator.Create_90(_expandBtnPicture);
        }

        public void InitializeControl(string title)
        {
            _textLabel.Text = title;
        }
        
        private void _expandBtnPicture_Paint(object sender, PaintEventArgs e)
        {
            var image = _expandedSubject.Value ? _resizedExpandBtnImage_90 : _resizedExpandBtnImage_0;
            e.Graphics.DrawImage(image, 0, 0);
        }

        private void _expandBtnPicture_Click(object sender, EventArgs e)
        {
            _expandedSubject.OnNext(!_expandedSubject.Value);
            _expandBtnPicture.Invalidate();
        }

        private void DisposeInternal()
        {
            using (_resizedExpandBtnImage_0)
            using (_resizedExpandBtnImage_90)
            using (_expandedSubject)
            using (_titleClickSubject)
            {
            }
        }

        private static class BitmapCreator
        {
            private const float BITMAP_SHRINK_RATE = 0.9f;

            public static Bitmap Create_0(Control pictureBox)
            {
                using (var bitmap = MakeTransparent(Resources.ExpandButtonImage))
                {
                    var resizeWidth = (int) (Math.Min(pictureBox.Width, pictureBox.Height) * BITMAP_SHRINK_RATE);
                    var resizeHeight = (int) (bitmap.Height * (resizeWidth / (double) bitmap.Width));
                    var resizeBmp = new Bitmap(resizeWidth, resizeHeight);
                    resizeBmp.MakeTransparent();
                    using (var graphics = Graphics.FromImage(resizeBmp))
                    {
                        graphics.InterpolationMode = InterpolationMode.HighQualityBicubic;
                        graphics.DrawImage(bitmap, 0, 0, resizeWidth, resizeHeight);
                        return resizeBmp;
                    }
                }
            }

            public static Bitmap Create_90(Control pictureBox)
            {
                var bitmap = Create_0(pictureBox);
                bitmap.RotateFlip(RotateFlipType.Rotate90FlipNone);
                return bitmap;
            }

            private static Bitmap MakeTransparent(Bitmap bitmap)
            {
                var clone = (Bitmap) bitmap.Clone();
                for (var i = 0; i < clone.Width; i++)
                {
                    for (var j = 0; j < clone.Height; j++)
                    {
                        var pixel = clone.GetPixel(i, j);
                        if (pixel.R > 100 && pixel.G > 100 && pixel.B > 100)
                        {
                            clone.SetPixel(i, j, Color.Transparent);
                        }
                    }
                }

                return clone;
            }
        }

        private void _textLabel_Click(object sender, EventArgs e)
        {
            _titleClickSubject.OnNext(Unit.Default);
        }
    }
}