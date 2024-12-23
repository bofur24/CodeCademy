// Space expedition Boolean Adventure

Console.WriteLine("You're the captain of a space expedition aimed at discovering new planets.");
Console.WriteLine("Your space agency has established a set of parameters that need regular evaluations to make informed decisions.");
Console.WriteLine("These parameters include atmospheric quality, gravity levels, and resource availability.");

Console.WriteLine("You have discovered 3 planets in the area");
Console.WriteLine("Argos Rho, or Armstrong Nebula");
Console.Write("What planet would you like to scan? ");
string planetScan = Console.ReadLine();

if (planetScan == "Argos Rho") {
  bool argosAtmosphereBreathable = false;
  bool argosGravityStable = false;
  bool argosResourcesSufficient = false;

  bool argosHabitable = argosAtmosphereBreathable && argosGravityStable;
  Console.WriteLine($"Is Argos Rho planet habitable {argosHabitable}");

  bool argosSuitableForExpansion = argosGravityStable || argosResourcesSufficient;
  Console.WriteLine($"Is Argos Rho planet suitable for expansion {argosSuitableForExpansion}");
    if (argosSuitableForExpansion == true) {
      Console.WriteLine("Argos Rho is suitable for expansion");
    }else {
      Console.WriteLine("Argos Rho is notsuitable for expansion");
    }

} else if (planetScan == "Armstrong Nebula") {
  bool armstrongAtmosphereBreathable = true;
  bool armstrongGravityStable = true;
  bool armstrongResourcesSufficient = true;

  bool armstrongHabitable = armstrongAtmosphereBreathable && armstrongGravityStable;
  Console.WriteLine($"Is Armstrong Nebula planet habitable {armstrongHabitable}");

  bool armstrongSuitableForExpansion = armstrongGravityStable || armstrongResourcesSufficient;
  Console.WriteLine($"Is Armstrong Nebula planet suitable for expansion {armstrongSuitableForExpansion}");
    if (armstrongSuitableForExpansion == true) {
      Console.WriteLine("Armstrong Nebula is suitable for expansion");
    }else {
      Console.WriteLine("Armstrong Nebula is notsuitable for expansion");
    }

}
