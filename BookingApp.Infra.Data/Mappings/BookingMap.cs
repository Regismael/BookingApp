using BookingApp.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BookingApp.Infra.Data.Mappings
{
    public class BookingMap : IEntityTypeConfiguration<Booking>
    {
        public void Configure(EntityTypeBuilder<Booking> builder)
        {
            builder.ToTable("BOOKING");

            builder.HasKey(b => b.Id);

            builder.Property(b => b.Id)
                .HasColumnName("ID")
                .IsRequired();

            builder.Property(b => b.RatingStatus)
                .HasColumnName("RATINGSTATUS")
                .HasConversion<int?>() // Convertendo para int? no banco de dados
                .HasColumnType("int")
                .IsRequired();

            builder.Property(b => b.CommentStatus)
                .HasColumnName("COMMENTSTATUS")
                .HasConversion<int?>()
                .HasColumnType("int")
                .IsRequired();

            builder.Property(b => b.StartDate)
                .HasColumnName("STARTDATE")
                .IsRequired();

            builder.Property(b => b.EndDate)
                .HasColumnName("ENDDATE")
                .IsRequired();

            builder.Property(b => b.CustomerId)
                .HasColumnName("CUSTOMER_ID")
                .IsRequired();

            builder.Property(b => b.VehicleId)
                .HasColumnName("VEHICLE_ID")
                .IsRequired();

            builder.HasOne(b => b.Customer)
                .WithMany(c => c.Bookings)
                .HasForeignKey(b => b.CustomerId)
                .OnDelete(DeleteBehavior.Cascade);

            builder.HasOne(b => b.Vehicle)
                .WithMany(v => v.Bookings)
                .HasForeignKey(b => b.VehicleId)
                .OnDelete(DeleteBehavior.Cascade);

                

        }
    }
}
