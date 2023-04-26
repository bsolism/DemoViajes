namespace DemoViajes.Domain.ValidationJourneys
{
    public class ValidateCarrierJourney
    {
        public ValidateCarrierJourney()
        {

        }
        public static bool ValidateJourneyCarrier(IEnumerable<Journey> Journeys, decimal distance)
        {
            decimal Km = distance;
            foreach (var journey in Journeys)
            {
                Km = Km + journey.Distance;
            }
            if (Km > 100) return false;

            return true;
        }
    }
}
