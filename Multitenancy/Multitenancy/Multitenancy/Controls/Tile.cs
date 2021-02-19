using System;
using Xamarin.Forms;

namespace Multitenancy.Controls
{
    class Tile : ContentView
    {
        public Tile(int row, int col, ImageSource imageSource)
        {
            Row = row;
            Col = col;

            Padding = new Thickness(1);
            Content = new Image
            {
                Source = imageSource
            };
        }

        public int Row { set; get; }

        public int Col { set; get; }
    }
}
