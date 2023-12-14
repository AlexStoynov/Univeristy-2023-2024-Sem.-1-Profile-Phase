using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConstantKeyword
{
    public class PrintLog
    {
        private int pagesPrinted;
        private const double printPricePerPage = 0.5;

        public PrintLog()
        { this.pagesPrinted = 0;}

        public double PrintPage()
        {
            this.pagesPrinted++;
            return printPricePerPage;
        }

        public double PrintPage(int pageCount)
        {
            this.pagesPrinted += pageCount;
            return printPricePerPage * pageCount;
        }

        public double GetCurrentRevenue()
        { return printPricePerPage * this.pagesPrinted; }
    }

}
