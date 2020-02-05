using System;
using System.Collections.Generic;
using burgershackapi.Models;
using burgershackapi.Repositories;

namespace burgershackapi.Services
{
    public class BurgersService
    {
        private readonly BurgersRepository _repo;
        public BurgersService(BurgersRepository br)
        {
            _repo = br;
        }
        internal IEnumerable<Burger> Get()
        {
            return _repo.Get();
        }

        internal object GetById(int id)
        {
            var exists = _repo.GetById(id);
            if (exists == null) { throw new Exception("invalid Id"); }
            return exists;
        }

        internal Burger Create(Burger newData)
        {
            _repo.Create(newData);
            return newData;
        }

        internal Burger Edit(Burger update)
        {
            var exists = _repo.GetById(update.Id);
            if (exists == null) { throw new Exception("Invalid Id"); }

            _repo.Edit(update);
            return update;
        }

        internal object Delete(int id)
        {
            throw new NotImplementedException();
        }
    }

}