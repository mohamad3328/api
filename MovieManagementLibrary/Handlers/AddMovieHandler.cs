﻿using api_m.Model;
using MediatR;
using MovieManagementLibrary.Command;
using MovieManagementLibrary.Interface;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MovieManagementLibrary.Handlers
{
    public class AddMovieHandler : IRequestHandler<AddMovieCommand, MovieModel>
    {


        private readonly IDataRepository _dataRepository;

        public AddMovieHandler(IDataRepository dataRepository)
        {
            _dataRepository = dataRepository;
        }

        public Task<MovieModel> Handle(AddMovieCommand request, CancellationToken cancellationToken)
        {
            return Task.FromResult(_dataRepository.AddMovie(request.model));
        }
    }
}
