using System.Collections.Generic;
using System.Threading.Tasks;
using AutoMapper;
using Microsoft.AspNetCore.Mvc;
using Microsoft.EntityFrameworkCore;
using vega.Controllers.Resources;
using vega.Models;
using vega.Persistance;

namespace vega.Controllers
{
    public class FeatureController : Controller
    {
        private readonly VegaDbContext _context;
        private readonly IMapper _mapper;
        public FeatureController(VegaDbContext context, IMapper mapper)
        {
            this._context = context;   
            this._mapper = mapper;   
        }

        [HttpGet("/api/features")]
        public async Task<IEnumerable<KeyValuePairResource>> GetFeatures()
        {
            var features = await _context.Features.ToListAsync();            
            return _mapper.Map<List<Feature>, List<KeyValuePairResource>>(features); 
        }
    }
}