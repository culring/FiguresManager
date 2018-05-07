using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Figures
{
    interface ViewInterface
    {
        void Add(Figure figure);
        void Edit(Figure figure);
        void Remove(Figure figure);
        void Refresh(List<Figure> figures);
    }
}
