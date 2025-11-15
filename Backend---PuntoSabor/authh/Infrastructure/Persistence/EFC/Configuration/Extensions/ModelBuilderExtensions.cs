using Backend___PuntoSabor.authh.Domain.Model.Aggregates;
using Microsoft.EntityFrameworkCore;

namespace Backend___PuntoSabor.authh.Infrastructure.Persistence.EFC.Configuration.Extensions;

public static class ModelBuilderExtensions
{
    public static void ApplyAuthhConfiguration(this ModelBuilder builder)
    {
        // Configuración de la entidad User
        builder.Entity<User>(entity =>
        {
            // Llave primaria
            entity.HasKey(u => u.Id);
            entity.Property(u => u.Id)
                .IsRequired()
                .ValueGeneratedOnAdd();

            entity.Property(u => u.Name)
                .IsRequired()
                .HasMaxLength(70);
                
            entity.Property(u => u.Email)
                .IsRequired()
                .HasMaxLength(254);
            
            /*entity.Property(u => u.Password)
                .IsRequired()
                .HasMaxLength(255);*/
            
            entity.Property(u => u.CreatedAt)
                .IsRequired();
            
            // Índices para mejorar performance
            entity.HasIndex(u => u.Email)
                .IsUnique();

        });   
    }
}