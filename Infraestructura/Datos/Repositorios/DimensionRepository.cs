﻿using System;
using System.Collections.Generic;
using System.Text;
using Dominio.Entities;
using Infraestructura.Utils;

namespace Infraestructura.Datos.Repositorios
{
    public class DimensionRepository : GenericRepository<Dimension>
    {
        public DimensionRepository(DbContext context) : base(context) { }
    }
}