using SharedLibrary.Models;
using System.Collections.Generic;
using System.Threading.Tasks;
using System;

namespace SharedLibrary.ReservationRepositories
{
    public interface IReservationRepository
    {
        Task<List<Reservation>> GetAllReservationsAsync();
        Task<Reservation> GetReservationByIdAsync(int reservationId);
        Task<List<Reservation>> GetReservationByDateAsync(DateTime startDate, DateTime endDate);
        Task<bool> IsSlotReservedAsync(DateTime date, string slot);
        Task<Reservation> AddReservationAsync(Reservation model);
        Task<Reservation> UpdateReservationAsync(Reservation model);
        Task<Reservation> DeleteReservationAsync(int reservationId);
    }
}