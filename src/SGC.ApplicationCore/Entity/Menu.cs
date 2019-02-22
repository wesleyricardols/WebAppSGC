using System.Collections;
using System.Collections.Generic;

namespace SGC.ApplicationCore.Entity
{
    public class Menu
    {
        public int Id { get; set; }
        public string Titulo { get; set; }
        public int? MenuId { get; set; }
        public ICollection<Menu> SubMenus { get; set; }
    }
}
