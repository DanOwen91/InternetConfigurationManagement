using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace DownloadSpeedChecker
{
    class ReadRequest
    {
        internal async Task<byte[]> init(Uri uri)
        {
            byte[] size;
            try
            {
                HttpClient clientControl = new HttpController().HttpClient();
                clientControl.CancelPendingRequests();

                size = await clientControl.GetByteArrayAsync(uri);

            }
            catch (Exception)
            {
                throw;
            }
            return size;
        }
    }
}
