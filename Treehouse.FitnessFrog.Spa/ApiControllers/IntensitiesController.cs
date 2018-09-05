using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Http;
using Treehouse.FitnessFrog.Shared.Models;

namespace Treehouse.FitnessFrog.Spa.ApiControllers
{
    public class IntensitiesController: ApiController
    {

        public IHttpActionResult Get()
        {
            var result = Enum.GetValues(typeof(Entry.IntensityLevel))
                .Cast<Entry.IntensityLevel>()
                .Select(il => new { id = (int)il, name = il.ToString() })
                .ToList();

            if (result == null)
            {
                return NotFound(); 
            }

          return  Ok(result);
        }
    }
}