﻿using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class PixTypeService
    {
        private IPixTypeRepository _pixTypeService;

        public PixTypeService()
        {
            _pixTypeService = new PixTypeRepository();
        }

        public int InsertPixType(PixType pixType)
        {
            return _pixTypeService.InsertPixType(pixType);
        }
    }
}
