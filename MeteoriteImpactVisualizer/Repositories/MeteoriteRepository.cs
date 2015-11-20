using DataAccess;
using MeteoriteImpactVisualizer.Models;
using MeteoriteImpactVisualizer.Repositories.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoriteImpactVisualizer.Repositories
{
    public class MeteoriteRepository : IMeteoriteRepository
    {

        private readonly MeteoriteContext _context;

        public MeteoriteRepository()
        {
            _context = new MeteoriteContext();
        }


        public IList<Meteorite> GetAllMeteorites()
        {
            return _context.Meteorite.ToList();
        }


        public Meteorite GetById(decimal id)
        {
            var meteorite = _context.Meteorite.Find(id);
            return meteorite;
        }
    }
}