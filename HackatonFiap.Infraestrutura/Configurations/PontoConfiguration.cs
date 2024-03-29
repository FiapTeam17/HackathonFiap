﻿using HackatonFiap.Dominio.Funcionario.Models;
using HackatonFiap.Dominio.Ponto.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using Microsoft.EntityFrameworkCore.ValueGeneration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HackatonFiap.Infraestrutura.Configurations
{
    internal class PontoConfiguration : IEntityTypeConfiguration<PontoModel>
    {
        public void Configure(EntityTypeBuilder<PontoModel> builder)
        {
            builder.ToTable("ponto");
            builder.HasKey(c => c.Id);
            builder.Property(c => c.Horario).HasMaxLength(200).IsRequired();
            builder.Property(c => c.tipo).IsRequired();
            builder
                .HasOne(a => a.Funcionario)
                .WithMany(a => a.Pontos)
                .HasConstraintName("FK_Ponto_Funcionario");
        }
    }
}
