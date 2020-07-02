using System.Collections.Generic;
using HelpLocally.Domain;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace HelpLocally.Web.Common
{
    public static class RoleTypes
    {
        public static readonly ICollection<SelectListItem> Roles = new List<SelectListItem>
        {
            new SelectListItem
            {
                Value = RolesDefaults.Admin,
                Text = "Administrator"
            },
            new SelectListItem
            {
                Value = RolesDefaults.Seller,
                Text = "Sprzedawca"
            },
            new SelectListItem
            {
                Value = RolesDefaults.Customer,
                Text = "Kupujący"
            },
        };
    }
}