using System;
using System.Drawing;
using System.Drawing.Imaging;

namespace UPCA {
    public class Barcode {
        private const int BarCodeHeight = 80;

        private Bitmap _newBitmap;
        private Graphics _g;
        private int _placeMarker;
        private int _imageWidth;
        private float _imageScale = 1;
        private string _upcaBegin = "0000000000000101";
        private readonly string[] _upcaLeft = { "0001101", "0011001", "0010011", "0111101", "0100011", "0110001", "0101111", "0111011", "0110111", "0001011" };
        private string _upcaMiddle = "01010";
        private readonly string[] _upcaRight = { "1110010", "1100110", "1101100", "1000010", "1011100", "1001110", "1010000", "1000100", "1001000", "1110100" };
        private string _upcaEnd = "1010000000000000";

        public Image CreateBarCode(string digits, int scale) {
            _imageWidth = 120;
            _imageScale = scale;
            _imageWidth = Convert.ToInt32(_imageWidth * _imageScale);
            var imageHeightHolder = Convert.ToInt32(BarCodeHeight * _imageScale);
            var incomingString = digits.ToUpper();
            if (incomingString.Length == 0) {
                return null;
            }

            _newBitmap = new Bitmap(_imageWidth, imageHeightHolder, PixelFormat.Format32bppArgb);
            _g = Graphics.FromImage(_newBitmap);
            _g.ScaleTransform(_imageScale, _imageScale);
            var newRec = new Rectangle(0, 0, _imageWidth, imageHeightHolder);
            _g.FillRectangle(new SolidBrush(Color.White), newRec);
            _placeMarker = 0;
            digits = digits.Substring(0, 11) + GetCheckSum(digits);

            for (int wholeSet = 1; wholeSet <= Convert.ToInt32(incomingString.Length); wholeSet++) {
                var currentAscii = Convert.ToChar(incomingString.Substring(wholeSet - 1, 1)) - 48;

                if (wholeSet == 1) {
                    DrawSet(_upcaBegin, _placeMarker, 0);
                    DrawSet(_upcaLeft[currentAscii], _placeMarker, 0);
                }
                else if (wholeSet <= 5) {
                    DrawSet(_upcaLeft[currentAscii], _placeMarker, 6);
                }
                else if (wholeSet == 6) {
                    DrawSet(_upcaLeft[currentAscii], _placeMarker, 6);
                    DrawSet(_upcaMiddle, _placeMarker, 0);
                }
                else if (wholeSet <= 11) {
                    DrawSet(_upcaRight[currentAscii], _placeMarker, 6);
                }
                else if (wholeSet == 12) {
                    DrawSet(_upcaRight[currentAscii], _placeMarker, 0);
                    DrawSet(_upcaEnd, _placeMarker, 0);
                }
            }

            var font = new Font("Courier New, Bold", 9);
            try {
                _g.DrawString(digits.Substring(0, 1), font, Brushes.Black, new PointF(0, 67));
                _g.DrawString(digits.Substring(1, 5), font, Brushes.Black, new PointF(22, 67));
                _g.DrawString(digits.Substring(6, 5), font, Brushes.Black, new PointF(60, 67));
                _g.DrawString(digits.Substring(11, 1), font, Brushes.Black, new PointF(108, 67));
            }
            finally {
                font.Dispose();
            }

            return Image.FromHbitmap(_newBitmap.GetHbitmap());
        }

        public int GetCheckSum(string barCode) {
            var leftSideOfBarCode = barCode.Substring(0, 11);
            var total = 0;
            int i;
            for (i = 0; i <= leftSideOfBarCode.Length - 1; i++)
            {
                var currentDigit = Convert.ToInt32(leftSideOfBarCode.Substring(i, 1));
                if ((i - 1) % 2 == 0) {
                    total += currentDigit * 1;
                }
                else {
                    total += currentDigit * 3;
                }
            }
            var iCheckSum = (10 - total % 10) % 10;
            return iCheckSum;
        }

        private void DrawSet(string upcCode, int drawLocation, int barHeight) {
            var currentLetterArray = new int[upcCode.Length];
            _placeMarker += upcCode.Length;
            barHeight = BarCodeHeight - barHeight;
            int i;
            for (i = 0; i <= upcCode.Length - 1; i++) {
                currentLetterArray[i] = Convert.ToInt16(upcCode.Substring(i, 1));
            }
            for (i = 0; i <= upcCode.Length - 1; i++) {
                if (currentLetterArray[i] == 0) {
                    _g.DrawLine(Pens.White, i + drawLocation, 0, i + drawLocation, barHeight - 6);
                }
                else if (currentLetterArray[i] == 1) {
                    _g.DrawLine(Pens.Black, i + drawLocation, 0, i + drawLocation, barHeight - 6);
                }
            }
        }

    }
}
