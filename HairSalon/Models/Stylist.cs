// things we need for the stylist:
// 1)list of stylists
//   a)details of the stylists
//   b)list of clients per stylist
// 2)must be able to add new stylist
using System.Collections.Generic;

namespace HairSalon.Models
{
  public class Stylist
  {
    public int StylistId {get; set;}
    public string StylistName {get; set;}
    public string StylistDetails {get; set;}
    public List<Client> Clients {get; set;}
  }
}