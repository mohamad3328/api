using api_m.Model;
using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Queries
{
    public record GetMovieListQuery() : IRequest<List<MovieModel>>;
    
    
}
