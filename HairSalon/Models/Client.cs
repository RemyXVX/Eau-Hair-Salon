// things we need for the client model
// 1)list of clients
//    a)details of clients
//    b)who is their stylist
// 2)create new clients

namespace HairSalon.Models
{
  public class ClientsController
  {
    public class Client
    {
      public int ClientId {get; set;}
      public string ClientName {get; set;}
      public string ClientDescription {get; set;}
      public int StylistId {get; set;}
      public Stylist Stylist {get; set;}
    }
  }
}