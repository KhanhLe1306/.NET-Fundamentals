// ImmutableVehicle car = new()
// {
//     Wheels = 4,
//     Color = "Hypersonic Grey",
//     Brand = "Chevrolet"
// };

ImmutableVehicle car = new(4, "Hypersonic Grey", "Chevrolet")
{
};

ImmutableVehicle repaintedCar = car with {Color = "Black Metalic"};

// ImmutableVehicle car = new(4)
// {
//     Color = "Hypersonic Grey",
//     Brand = "Chevrolet"
// };

var (wheels, color, brand) = car;

print($"Wheels: {wheels}, color: {color}, brand: {brand}");