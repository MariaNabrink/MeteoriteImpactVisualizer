using DataAccess;
using MeteoriteImpactVisualizer.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MeteoriteImpactVisualizer.Services.Interfaces
{
    public interface IMeteoriteService
    {
        IList<Meteorite> GetAllMeteorites();
        Meteorite GetById(decimal id);
    }
}
