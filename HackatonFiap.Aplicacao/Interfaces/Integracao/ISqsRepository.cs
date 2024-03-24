﻿using HackatonFiap.Dominio.Ponto.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonFiap.Aplicacao.Interfaces.Integracao;
public interface ISqsRepository
{
    Task SolicitarRelatorio(PeriodoModel periodoModel);
}
