namespace doctoreslist
{
    public partial class Form1 : Form
    //esta lista privada agarra como parametro la clase doctor
    // mediante la cual accederemos a las antes mencionadas
    {
        private List<Doctores> doctoreslist = new List<Doctores>();

        Director director = new Director();
        public Form1()
        {
            InitializeComponent();

            //aca inicializaremos el combobox me permite cargar el listado de todos los directors

            lbdoctores.DataSource = director.LoadDirectorsData();
            lbdoctores.DisplayMember = "Name";
        }

        private void btnagregar_Click(object sender, EventArgs e)
        //validamos los campos como el id, doctores, numero de teleno y email

        {
            Doctores doctores = new Doctores
            {
                Id = doctoreslist.Count + 1,
                DoctoresName = tbdoctor.Text.Trim(),
                numerotelefono = tbtelefono.Text.Trim(),
                Email = tbemail.Text.Trim(),
            };

            doctoreslist.Add(doctores);
            lbdoctores.Items.Add(doctores);
            ClearInputs();

        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (GetSelectedDoctoresListBoxIndex() >= 0)
            {
                doctoreslist.RemoveAt(GetSelectedDoctoresListBoxIndex());
                lbdoctores.Items.RemoveAt(GetSelectedDoctoresListBoxIndex());
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Selecciona una fila antes de eliminarla");
            }
        }


        private int GetSelectedDoctoresListBoxIndex()
        {
            return lbdoctores.SelectedIndex;
        }



        //BOTON EDITAR

        //Ahora que me acuerdo usted ing nos enseño o nos mostro
        //otra forma mas facil de editar es sellecionar el indice 
        //eliminar el dato y agregarlo a la lista pero no me acuerdo muy bien con remoteat
        private void btneditar_Click(object sender, EventArgs e)
        {
            if (GetSelectedDoctoresListBoxIndex() >= 0)
            {
                //mandamos a llamar esta variable doctor
                Doctores doctores = new Doctores
                {
                    Id = doctoreslist[GetSelectedDoctoresListBoxIndex()].Id,
                    DoctoresName = lbldoctor.Text.Trim(),
                    numerotelefono = lbltelefono.Text.Trim(),
                    Email = lblemail.Text.Trim(),
                };

                //con la lista doctor pasamos el list con el index del elemento seleccionado etc

                doctoreslist[GetSelectedDoctoresListBoxIndex()] = doctores;
                lbdoctores.Items[GetSelectedDoctoresListBoxIndex()] = doctores;
                ClearInputs();
            }
            else
            {
                MessageBox.Show("Selecciona una opcion para editar");
            }

        }

        private void lbdoctores_SelectedIndexChanged(object sender, EventArgs e)
            //Este evento es el doble clic en el listbox de doctores
            //no lo muestro porque me da error
        {
            if (GetSelectedDoctoresListBoxIndex() >= 0)
            {
                Doctores selectedDoctores = doctoreslist[GetSelectedDoctoresListBoxIndex()];
                //este parametro que me va a cargar los datos de la lista
                DisplayDoctoresInfo(selectedDoctores);
            }

        }






        private void ClearInputs()
        {
            tbdoctor.Clear();
            tbtelefono.Clear();
            tbemail.Clear();

        }


        //FUNCION selectedDoctores

        private void DisplayDoctoresInfo(Doctores doctores)
        {
            tbdoctor.Text = doctores.DoctoresName;
            tbtelefono.Text = doctores.numerotelefono;
            lblemail.Text = doctores.Email;
        }

    }
}







//NO SE PORQUE ME DA ESE ERROR DEBE SER EL VISUAL LO REINICIARE