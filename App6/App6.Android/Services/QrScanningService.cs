using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using App6.Service;
using ZXing.Mobile;
using System.Threading.Tasks;
using System.Runtime.CompilerServices;

[assembly: Dependency(nameof(App6.Droid.Services.QrScanningService), LoadHint.Default)]
namespace App6.Droid.Services
{
    
        public class QrScanningService : IQrScanningService
        {
            public async Task<string> ScanAsync()
            {
                var optionsDefault = new MobileBarcodeScanningOptions();
                var optionsCustom = new MobileBarcodeScanningOptions();

                var scanner = new MobileBarcodeScanner()
                {
                    TopText = "Scan the QR Code",
                    BottomText = "Please Wait",
                };

                var scanResult = await scanner.Scan(optionsCustom);
                return scanResult.Text;
            }
        }
    }
