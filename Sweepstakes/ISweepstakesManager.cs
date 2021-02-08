using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    interface ISweepstakesManager
    {
        void insertSweepstakes(Sweepstakes sweepstakes);

        Sweepstakes GetSweepstakes();

    }
}
