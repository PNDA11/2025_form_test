using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace テトリス
{
    public abstract class Block
    {
        protected abstract Position[][] Tiles {  get; }
        protected abstract Position StartOffset { get; }
        public abstract int Id {  get; }

        private int rota
    }
}
