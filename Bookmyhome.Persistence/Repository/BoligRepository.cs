﻿using Bookmyhome.Application.RepositoryInterfaces;
using Bookmyhome.Domain.Models;
using Bookmyhome.Persistence.ContextDB;
using Microsoft.EntityFrameworkCore;
using Microsoft.Identity.Client;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bookmyhome.Persistence.Repository
{
	public class BoligRepository : IBoligRepository
	{
        private readonly MyDBContext _db;
        public BoligRepository(MyDBContext dbcontext)
        {
            _db = dbcontext;
        }

        public List<Bolig> GetAllBolig()
        {
            return _db.BoligEF.OrderBy(b=>b.BoligID).Include(b=>b.BookingList).Include(b=>b.AnmeldelseList).Include(b=>b.Adresse).ThenInclude(a=>a.PostnummerOgBy).ToList();
        }

        public Bolig GetBolig(int id) 
        {
            return _db.BoligEF.Single(b => b.BoligID == id);
        }

        public void AddBolig(Bolig bolig)
        {
            _db.BoligEF.Add(bolig);
            _db.SaveChanges();
        }

        public void UpdateBolig(Bolig bolig)
        {
            var existingBolig = _db.BoligEF.Single(b => b.BoligID == bolig.BoligID);
            if (existingBolig == null)
            {
                return;
            }
            _db.Entry(existingBolig).CurrentValues.SetValues(bolig);
            _db.SaveChanges();
        }

        public bool DeleteBolig(int id)
        {
            var bolig = _db.BoligEF.Single(b => b.BoligID == id);
            if (bolig == null)
            {
                return false;
            }
            _db.BoligEF.Remove(bolig);
            _db.SaveChanges(); 
            return true;
        }
    }
}
