using Models;
using Services;

namespace Controllers
{
    public class PixTypeController
    {
        private PixTypeService _pixTypeService;

        public PixTypeController()
        {
            _pixTypeService = new PixTypeService();
        }

        public int InsertPixType(PixType pixType)
        {
            return _pixTypeService.InsertPixType(pixType);
        }
    }
}