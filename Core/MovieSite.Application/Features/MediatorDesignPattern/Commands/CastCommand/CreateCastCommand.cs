﻿using MediatR;

namespace MovieSite.Application.Features.MediatorDesignPattern.Commands.CastCommand
{
    public class CreateCastCommand : IRequest
    {
        public string Title { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public string ImageUrl { get; set; }
        public string? Overview { get; set; }
        public string? Biography { get; set; }
    }
}
