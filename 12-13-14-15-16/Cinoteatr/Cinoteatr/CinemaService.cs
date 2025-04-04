using System.Threading.Tasks;

namespace Cinoteatr
{
    public class CinemaService
    {
        public async Task<bool> ConfirmReservationAsync()
        {
            await Task.Delay(2000);
            return true;
        }
    }
}
