using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Identity;


namespace Core.Models
{
    public class ApplicationUser : IdentityUser
    {

        [Display(Name = "Телефон")]
        public override string PhoneNumber { get => base.PhoneNumber; set => base.PhoneNumber = value; }

        [Display(Name = "Ошибок входа")]
        public override int AccessFailedCount { get => base.AccessFailedCount; set => base.AccessFailedCount = value; }

        [Display(Name = "Email подтвержден")]
        public override bool EmailConfirmed { get => base.EmailConfirmed; set => base.EmailConfirmed = value; }

        [Display(Name = "Заблокирован")]
        public override bool LockoutEnabled { get => base.LockoutEnabled; set => base.LockoutEnabled = value; }

        [Display(Name = "Блокировка до")]
        public override DateTimeOffset? LockoutEnd { get => base.LockoutEnd; set => base.LockoutEnd = value; }

        [Display(Name = "Тел. подтвержден")]
        public override bool PhoneNumberConfirmed { get => base.PhoneNumberConfirmed; set => base.PhoneNumberConfirmed = value; }

        [Display(Name = "Пользователь")]
        public override string UserName { get => base.UserName; set => base.UserName = value; }
         
    }
}
