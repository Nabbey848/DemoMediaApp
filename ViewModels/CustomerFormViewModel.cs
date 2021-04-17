using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using VidlyTutorial.Models;

namespace VidlyTutorial.ViewModels
{
    public class CustomerFormViewModel
    {
        public IEnumerable<MembershipType> MembershipTypes { get; set; }
        public int? Id { get; set; }
        public string Name { get; set; }
        public int? MembershipTypeId { get; set; }
        public bool IsSubscribedToNewsLetter { get; set; }

        public string Title
        {
            get
            {
                if (Id != 0)
                    return "Edit Customer";

                return "New Customer";
            }
        }

        public CustomerFormViewModel()
        {

        }


        public CustomerFormViewModel(Customer customer)
        {
            Id = customer.Id;
            Name = customer.Name;
            IsSubscribedToNewsLetter = customer.IsSubscribedToNewsLetter;
            MembershipTypeId = customer.MembershipTypeId;
        }
    }

}