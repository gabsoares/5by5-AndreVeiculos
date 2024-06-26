﻿using Models;
using Repositories;
using Repositories.Interface;

namespace Services
{
    public class PixService
    {
        private IPixRepository _pixRepository;

        public PixService()
        {
            _pixRepository = new PixRepository();
        }

        public int InsertPix(Pix pix)
        {
            return _pixRepository.InsertPix(pix);
        }
    }
}
