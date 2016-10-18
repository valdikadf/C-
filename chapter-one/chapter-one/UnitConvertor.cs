using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace chapter_one
{
    class UnitConvertor
    {
        int ratio;
        public UnitConvertor(int unitRatio) { ratio = unitRatio; }
        public int Convart(int unit) { return ratio * unit; }
    }
}
