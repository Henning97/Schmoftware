using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Schmoftware
{
    public class Fakultaet
    {
        #region Constructor

        public Fakultaet()
        {

        }

        #endregion Constructor

        #region Public Methods

        /// <summary>
        /// Ermittelt die Fakultät
        /// </summary>
        /// <param name="number">Nummer</param>
        /// <returns>Fakultät</returns>
        public ulong GetFakultaet(ulong number)
        {
            if (number < 2)
            {
                return 1;
            }

            ulong retVal = 1;

            for (ulong i = 2; i <= number; i++)
            {
                retVal *= i;
            }

            //Rückgabewert
            return retVal;
        }

        #endregion Public Methods
    }
}
