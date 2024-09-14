



using Lab5_ONIONArxitectura.Controllers;



RoleController roleController = new();
while (true)
{
      Console.WriteLine(@"
      0.Finish
      1.Create Role
      2.GetAllByAdmin
      
");
      AddOption:string strOption = Console.ReadLine();
      if (!int.TryParse(strOption,out int option))
      {
            Console.WriteLine("Option is not valid");
            goto AddOption;
      }

      if (option==0)
      {
            Console.WriteLine("Proses is finished");
            break;
      }
      switch (option)
      {
            case 1:
                  roleController.Create();
                  break;
            case 2:
                  roleController.GetAllByAdmin();
                  break;
            default:
                  Console.WriteLine("Please enter exist option");
                  goto AddOption;
                  break;
      }
}