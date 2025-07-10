using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Avalonia;
using Avalonia.Controls;
using Avalonia.Media;

namespace MCUConfigurator.ViewModels
{
    public class TSSOP8Chip : Control
    {
        // Определите размеры микросхемы
        private const double ChipWidth = 10;
        private const double ChipHeight = 50;
        private const double PinWidth = 2;
        private const double PinLength = 5;
        private const double PinSpacing = 12; // 

        public override void Render(DrawingContext context)
        {
            base.Render(context);

            // Рисуем корпус микросхемы
            var bodyRect = new Rect(0, 0, ChipWidth, ChipHeight);
            context.FillRectangle(Brushes.Gray, bodyRect);

            // Рисуем выводы микросхемы
            for (int i = 0; i < 8; i++)
            {
                double pinX = (i < 4) ? -PinWidth : ChipWidth; // Левый или правый ряд
                pinX += (i % 4) * PinSpacing; // Расположение выводов по ширине

                // Вертикальное смещение для верхних и нижних пинов
                double pinY = (i < 4) ? -PinLength : ChipHeight; // Верхний или нижний ряд

                // Рисуем вывод
                var pinRect = new Rect(pinX, pinY - PinLength / 2, PinWidth, PinLength);
                context.FillRectangle(Brushes.Black, pinRect);
                
            }
        }
    }
}
