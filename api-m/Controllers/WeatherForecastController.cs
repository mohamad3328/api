using api_m.Model;
using MediatR;
using Microsoft.AspNetCore.Mvc;
using MovieManagementLibrary.Command;
using MovieManagementLibrary.Handlers;
using MovieManagementLibrary.Queries;

namespace api_m.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private readonly IMediator _mediator;

        public WeatherForecastController(IMediator mediator)
        {
            _mediator = mediator;
        }
        // GET: api/<MoviesController>
        [HttpGet]
        public async Task<List<MovieModel>> Get()
        {
            return await _mediator.Send(new GetMovieListQuery());
        }
        [HttpGet("{id}")]
        public async Task<MovieModel> Get(int id)
        {
            return await _mediator.Send(new GetMovieByIdQuery(id));
        }
        [HttpPost]
        public async Task<MovieModel> post(MovieModel movieModel)
        {
            return await _mediator.Send(new AddMovieCommand(movieModel));

        }

    }
}