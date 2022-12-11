using System;
using WisdomPetMedicine.Common;

namespace WisdomPetMedicine.Pet.Api.IntegrationEvents
{
    public class PetFlaggedForAdoptionIntegrationEvent : IIntegrationEvent  //uses this class to don't expose domain class
    {
        public Guid Id { get; set; }
        public string Name { get; set; }
        public string Breed { get; set; }
        public int Sex { get; set; }
        public string Color { get; set; }
        public DateTime DateOfBirth { get; set; }
        public string Species { get; set; }
    }
}