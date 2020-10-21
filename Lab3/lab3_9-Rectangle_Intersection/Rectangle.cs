using System;
using System.Collections.Generic;
using System.Text;

namespace lab3_9_Rectangle_Intersection
{
    class Rectangle
    {
        public string Id { get; }
        public int Width { get; }
        public int Height { get; }
        public int LeftTopCorner_x { get; }
        public int LeftTopCorner_y { get; }
        public int CalculateRightBottomCorner_x()
        {
            return (LeftTopCorner_x + Width);
        }
        public int CalculateRightBottomCorner_y()
        {
            return (LeftTopCorner_y + Height);
        }
        public Rectangle(string id, int width, int height, int x, int y)
        {
            Id = id;
            Width = width;
            Height = height;
            LeftTopCorner_y = y;
            LeftTopCorner_x = x;
        }
        public bool CheckIntersection(Rectangle second)
        {
            var firstLeftTop_y = LeftTopCorner_y;
            var firstLeftTop_x = LeftTopCorner_x;
            var firstRightBottom_y = CalculateRightBottomCorner_y();
            var firstRightBottom_x = CalculateRightBottomCorner_x();
            var secondLeftTop_y = second.LeftTopCorner_y;
            var secondLeftTop_x = second.LeftTopCorner_x;
            var secondRightBottom_y = second.CalculateRightBottomCorner_y();
            var secondRightBottom_x = second.CalculateRightBottomCorner_x();

            return (secondRightBottom_x <= firstRightBottom_x && secondRightBottom_y >= firstRightBottom_y &&
                    secondRightBottom_x >= firstLeftTop_x && secondRightBottom_y <= firstLeftTop_y) ||
                   (secondLeftTop_x <= firstRightBottom_x && secondLeftTop_y >= firstRightBottom_y &&
                    secondLeftTop_x >= firstLeftTop_x && secondLeftTop_y <= firstLeftTop_y);
        }
    }
}
