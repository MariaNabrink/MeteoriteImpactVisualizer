using DataAccess;
using MeteoriteImpactVisualizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MeteoriteImpactVisualizer.Repositories.Interfaces
{
    public interface IMeteoriteRepository
    {
        IList<Meteorite> GetAllMeteorites();
        Meteorite GetById(decimal id);
    }
}