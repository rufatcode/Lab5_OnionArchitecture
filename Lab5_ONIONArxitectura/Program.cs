



using Lab5_ONIONArxitectura.Controllers;
using Lab5_ONIONArxitectura.Domain.Entities;



RoleController roleController = new();
while (true)
{
      Console.WriteLine(@"
      0.Finish
      1.Create Role
      2.GetAllByAdmin
      3.Update
      4.Delete
      5.DeleteFromDb
      6.GetById
      7.GetAll
      
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
            case 3:
                  roleController.Update();
                  break;
            case 4:
                  roleController.Delete();
                  break;
            case 5:
                  roleController.DeleteFromDb();
                  break;
            case 6:
                  roleController.GetById();
                  break;
            case 7:
                  roleController.GetAll();
                  break;
                      
            default:
                  Console.WriteLine("Please enter exist option");
                  goto AddOption;
                  break;
      }
}