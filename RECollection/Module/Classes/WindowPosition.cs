using DataStore;
using System.Linq;
using System.Windows;

namespace RECollection.Module.Classes
{
    public class WindowPosition
    {
        public double Top { get; private set; }
        public double Left { get; private set; }
        public double Width { get; private set; }
        public double Height { get; private set; }
        DataCoreEntity db;

        public WindowPosition(double windowWidth, double windowHeight)
        {
            db = new DataCoreEntity();
            var position = db.WinPositions.FirstOrDefault();

            if (position == null)
            {
                var subX = windowWidth / 2;
                var subY = windowHeight / 2;

                var screenX = SystemParameters.PrimaryScreenWidth / 2;
                var screenY = SystemParameters.PrimaryScreenHeight / 2;

                position = new WinPosition() { Id = 1 };
                Equalize(screenY - subY, screenX - subX, windowWidth, windowHeight, position);
                db.WinPositions.Add(position);

                db.SaveChanges();
            }
            else
            {
                Top = position.Top;
                Left = position.Left;
                Width = position.Width;
                Height = position.Height;
            }
        }

        public void SavePosition(double top, double left, double width, double height)
        {
            if (Top != top || Left != left || Height != height || Width != width)
            {
                var position = db.WinPositions.FirstOrDefault();
                Equalize(top, left, width, height, position);
                db.SaveChanges();
            }
        }

        private void Equalize(double top, double left, double width, double height, WinPosition position)
        {
            Top = top;
            Left = left;
            Width = width;
            Height = height;

            position.Left = (float)left;
            position.Top = (float)top;
            position.Width = (float)width;
            position.Height = (float)height;
        }
    }
}
