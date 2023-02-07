namespace Practica4
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            // programa que usa la función Math.PI
            string name = "Quentin";
            int x = 3;
            x = x * 17;
            double d = Math.PI / 2;
            MessageBox.Show("name is "+name + "\nx is "+x +"\nd is "+d);
            // Para qué sirve \n??
            //sirve para dar un salto de linea 
            // Qué hace la función PI
            //la funcion pi obtine el numero pi (3.14...)
            // cuál es el valor de la variable d?
            //El valor de la variable D es igual a pi entre 2 
            

        }

        private void button2_Click(object sender, EventArgs e)
        {
            int cont = 0;
            while (cont < 10)
            {
                cont = cont + 1;
            }
            for (int i = 0; i < 5; i++)
            {
                cont = cont - 1;
            }
            // cuanto vale cont?
            //count vale 5
            MessageBox.Show("La respuesta es: " + cont);
        }
    }
}