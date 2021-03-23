using Google.Protobuf.WellKnownTypes;
using Grpc.Net.Client;
using System;
using System.Threading.Tasks;

namespace PersonClient
{
    class Program
    {
        static async Task Main(string[] args)
        {
            using var channel = GrpcChannel.ForAddress("https://localhost:5001");
            var client = new PersonRegistration.PersonRegistrationClient(channel);

            Console.Write("Name: ");
            var name = Console.ReadLine();

            Console.WriteLine("Gender: ");
            var gender = Console.ReadLine();

            Console.WriteLine("Age: ");
            var age = Console.ReadLine();

            Console.WriteLine("Id:");
            var id = Console.ReadLine();

            var personToBeAdded = new Person()
            {
                Name = name.Trim().Length > 0 ? name : "undifined",
                Gender=gender.Trim().Length > 0 ? gender : "undifined",
                Age=age.Trim().Length > 0 ?Int32.Parse(age): 0,
                ID=id.Trim().Length>0?id:"undifined"
            };
            var response = await client.AddPersonAsync(
                new AddPersonRequest { Person = personToBeAdded });
            Console.WriteLine("Adding status: " + response.Status);

            var responseGetAll= client.GetAllPersons(new Empty());
            Console.WriteLine("Persons from server: " + responseGetAll);
            Console.WriteLine("Press any key to exit...");
            Console.ReadKey();

        }
    }
}
