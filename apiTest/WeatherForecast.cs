namespace apiTest
{
	public class WeatherForecast
	{
		public DateTime Date { get; set; }

		public static float pi = 3.142F;

		public int TemperatureC { get; set; }

		public int TemperatureF => 32 + (int)(TemperatureC / 0.5556);

		public string? Summary { get; set; }
	}
}