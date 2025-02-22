﻿using AutoMapper;
using Application.Common.Mappings;
using Domain;

namespace Application.CQRS.Queries.Orders.GetOrderDetails
{
    public class OrderDetailsVm : IMapWith<Order>
    {
        public Guid Id { get; set; }
        public Guid BuildingId { get; set; }
        public string Name { get; set; }
        public string Phone { get; set; }
        public DateTime CreationDate { get; set; }
        public void Mapping(Profile profile)
        {
            profile.CreateMap<Order, OrderDetailsVm>()
                .ForMember(x => x.Id,
                opt => opt.MapFrom(order => order.Id))
                .ForMember(x => x.BuildingId,
                opt => opt.MapFrom(order => order.RowId))
                .ForMember(x => x.Name,
                opt => opt.MapFrom(order => order.Name))
                .ForMember(x => x.Phone,
                opt => opt.MapFrom(order => order.Phone))
                .ForMember(x => x.CreationDate,
                opt => opt.MapFrom(order => order.CreationDate));
        }
    }
}
