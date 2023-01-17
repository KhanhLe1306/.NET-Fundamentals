partial class Program {
    public record ImmutableVehicle(int Wheels, string? Color, string? Brand);
    // This line auto generate fields, constructor, and destructor
    // This equals

    
    // public record ImmutableVehicle
    // {
    //     public int Wheels { get; set; }
    //     public string? Color { get; set; }
    //     public string? Brand { get; set; }

    //     // Constructor

    //     // public ImmutableVehicle(int? wheels){
    //     //     Wheels = wheels;
    //     // }

    //     public void Deconstruct(out int wheels, out string color, out string brand){
    //         wheels = Wheels;
    //         color = Color!;
    //         brand = Brand!;
    //     } 
    // }
}