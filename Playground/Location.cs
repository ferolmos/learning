namespace Playground
{
  public struct Location
  {
    public int Longitude, Latitude;
    public string Direction;

    public Location(int longitude, int latitude, string direction)
    {
      this.Longitude = longitude;
      this.Latitude = latitude;
      this.Direction = direction;
    }
  }
}
