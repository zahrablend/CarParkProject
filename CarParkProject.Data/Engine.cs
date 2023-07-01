namespace CarParkProject.Data
{
    public class Engine
    {
        public ushort Power { get; set; }
        public ushort Volume { get; set; }
        public EngineType EngineType { get; set; }
        public string? SerialNumber { get; set; } // PJ12345U123456P
    }
}