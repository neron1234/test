using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace App6.Service
{
    interface IQrScanningService
    {
        Task<string> ScanAsync();
    }
}
