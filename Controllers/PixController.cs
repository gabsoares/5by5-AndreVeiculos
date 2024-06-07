using Models;
using Services;

namespace Controllers
{
    public class PixController
    {
        private PixService _pixService;

        public PixController()
        {
            _pixService = new PixService();
        }

        public int InsertPix(Pix pix)
        {
            return _pixService.InsertPix(pix);
        }
    }
}