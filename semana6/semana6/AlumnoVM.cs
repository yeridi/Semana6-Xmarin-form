using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Text;

namespace semana6
{
    class AlumnoVM
    {
        public ObservableCollection<UserGroupM> UserList { get; set; }
        public AlumnoVM() {
            this.UserList = new ObservableCollection<UserGroupM>();

            var group1 = new List<Alumno> {
                new Alumno("sekiri","Abdelai",43),
                new Alumno("Crhis","Huaman",19)
            };
            UserList.Add(new UserGroupM("Group1", group1));

            var group2 = new List<Alumno> {
                new Alumno("Yamil","Delgado",20),
                new Alumno("Crhis","Huaman",19)
            };
            UserList.Add(new UserGroupM("Group2", group2));
        }
    }
}
