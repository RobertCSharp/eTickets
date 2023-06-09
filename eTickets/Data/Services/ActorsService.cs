﻿using eTickets.Models;
using System.Collections.Generic;
using System.Linq;
using System.Security.AccessControl;
using System.Threading.Tasks;
using eTickets.Data.Base;
using Microsoft.EntityFrameworkCore;

namespace eTickets.Data.Services
{
    public class ActorsService : EntityBaseRepository<Actor>, IActorsService
    {
        public ActorsService(AppDbContext context) : base(context) { }
    }
}
