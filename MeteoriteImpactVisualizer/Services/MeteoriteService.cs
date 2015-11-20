using DataAccess;
using MeteoriteImpactVisualizer.Models;
using MeteoriteImpactVisualizer.Repositories;
using MeteoriteImpactVisualizer.Repositories.Interfaces;
using MeteoriteImpactVisualizer.Services.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoriteImpactVisualizer.Services
{
    public class MeteoriteService : IMeteoriteService
    {

        private IMeteoriteRepository _repository;

        public MeteoriteService()
        {
            _repository = new MeteoriteRepository();
        }

        public IList<Meteorite> GetAllMeteorites()
        {
            return _repository.GetAllMeteorites();
        }

        public Meteorite GetById(decimal id)
        {
            return _repository.GetById(id);
        }
    }
}