using Microsoft.AspNetCore.Components;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AzureBlazorUppgift.Machines
{
    public class MachineClass
    {

        public Guid Id { get; set; }
        [Display(Name = "Machine name")]
       
        public string Name { get; set; }

        [Display(Name = "Latest data sent")]
        public string LatestSentData { get; set; }
        public bool Online { get; set; }
        public string Status => Online ? "Online" : "Offline";
        public string Icon => Online ? $"/Assets/Icons/001-check.svg" : $"/Assets/Icons/002-delete.svg";
            
        public string Commands { get; set; }


    }
}
