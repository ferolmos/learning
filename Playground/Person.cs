using System.Text;

namespace Playground
{
  public class Person
  {
    public int Identifier { get; set; }
    public string Name { get; set; }

    public Person(int id, string name) {
      this.Identifier = id;
      this.Name = name;
    }

    public string Presentation() {
      return $"Hi, my name is {this.Name}.";
    }

    public static string RepitText(ref int times, ref string message)
    {

      times = times > 5 ? 5 : times;
      message = string.IsNullOrEmpty(message) ? "Please send me something to say." : message;

      var sb = new StringBuilder();
      for (int i = 0; i < times; i++)
      {
        sb.AppendLine(message);
      }

      return sb?.ToString();
    }

    public string RepitText(string message)
    {
      return $"{this.Presentation()} You aske me to say {message}";
    }
  }
}
