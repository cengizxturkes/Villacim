using Application.Features.Villa.Dtos;
using Application.Services.Repositories;
using AutoMapper;
using Domain.Entities;
using MediatR;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Application.Features.Villa.Commands.CreateVilla
{
    public partial class CreatedVillaCommand : IRequest<CreatedVillaDto>
    {
        public int Id { get; set; }
        public string VillaName { get; set; }
        public string ImageUrl { get; set; }
        public string Address { get; set; }
        public virtual Owner Owner { get; set; }
        public string Description { get; set; }
        public decimal Price { get; set; }
        public virtual Property Property { get; set; }

        public class CreatedVillaCommandHandler : IRequestHandler<CreatedVillaCommand, CreatedVillaDto>
        {
            private readonly IVillaRepository _villaRepository;
            private readonly IMapper _mapper;


            public CreatedVillaCommandHandler(IVillaRepository villaRepository, IMapper mapper)
            {
                _villaRepository = villaRepository;
                _mapper = mapper;

            }

            public async Task<CreatedVillaDto> Handle(CreatedVillaCommand request, CancellationToken cancellationToken)
            {
               Domain.Entities. Villa mappedVilla = _mapper.Map<Domain.Entities.Villa>(request);
                Domain.Entities.Villa createdVilla = await _villaRepository.AddAsync(mappedVilla);
                CreatedVillaDto createdVillaDto = _mapper.Map<CreatedVillaDto>(createdVilla);
                return createdVillaDto;

            }
        }
    }
}
