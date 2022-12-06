using api_m.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Interface
{
    public interface IDataRepository
    {
        List<MovieModel> GetMovies();
        MovieModel AddMovie(MovieModel movie);
    }
}
