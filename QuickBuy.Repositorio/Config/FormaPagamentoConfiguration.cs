﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using QuickBuy.Dominio.ObjetoDeValor;

namespace QuickBuy.Repositorio.Config
{
    public class FormaPagamentoConfiguration : IEntityTypeConfiguration<FormaPagamento>
    {
        public void Configure(EntityTypeBuilder<FormaPagamento> builder)
        {
            builder.HasKey(f => f.Id);
            builder.Property(f => f.Nome).IsRequired().HasMaxLength(50);
            builder.Property(f => f.Descricao).IsRequired().HasMaxLength(100);
            //builder.Property(f => f.EhBoleto);
            //builder.Property(f => f.EhCartaoCredito);
            //builder.Property(f => f.EhDeposito);
            //builder.Property(f => f.NaoFoiDefinido);
        }
    }
}
