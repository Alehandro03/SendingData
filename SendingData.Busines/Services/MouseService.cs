using SendingData.Busines.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace SendingData.Busines.Services
{
    public class MouseService
    {
        public MouseModel AddCoordinatesInMouseModel(MouseModel model)
        {
            int CursorX = Cursor.Position.X;
            int CursorY = Cursor.Position.Y;

            return;
        }
        
    }
}
