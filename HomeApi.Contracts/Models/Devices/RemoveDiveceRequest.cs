using System.ComponentModel.DataAnnotations;

namespace HomeApi.Contracts.Models.Devices
{
    /// <summary>
    /// Удаляет поддержку устройства.
    /// </summary>
    public class RemoveDiveceRequest
    {
        public string Name { get; set; }
        public string Manufacturer { get; set; }
        public string Model { get; set; }
        public string SerialNumber { get; set; }
    }
}