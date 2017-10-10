using AutoMapper;
using BL.BL.Interfaces;
using BL.DTO;
using DAL.Entities;
using System.Data.Entity;

namespace BL.BL.Concrete
{
    public class Update : BaseDbContext, IUpdate
    {
        public Personal UpdateUser(PersonalDTO _PersonalDTO)
        {
            var config = new MapperConfiguration(cfg => cfg.CreateMap<PersonalDTO, Personal>());
            var mapper = config.CreateMapper();
            var model = mapper.Map<PersonalDTO, Personal>(_PersonalDTO);

            db.Entry(model).State = EntityState.Modified;
            db.SaveChanges();

            return model;
        }
    }
}
