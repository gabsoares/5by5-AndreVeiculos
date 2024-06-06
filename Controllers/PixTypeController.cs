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

        public bool InsertPixType(PixType pixType)
        {
            return _pixTypeService.InsertPixType(pixType);
        }
    }
}