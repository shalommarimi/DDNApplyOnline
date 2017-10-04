using AutoMapper;
using BL.DTO;
using BL.BL.Interfaces;
using DAL.Entities;
using System.Data.Entity;

namespace BL.BL.Concrete
{
    public class Update : BaseDbContext, IUpdate
    {
        public Personal UpdateUser(PersonalDTO _PersonalDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<SubscriberDTO, Subscriber>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            return model;
        }
    }
}
