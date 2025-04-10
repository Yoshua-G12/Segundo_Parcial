using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Newtonsoft.Json;
using System.IO;


namespace Segundo_Parcial
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        List<Libro> libros = new List<Libro>();
        List<Lector> lector = new List<Lector>();
        List<Prestamos> prestamos = new List<Prestamos>();
        private void cmbnombrelector_SelectedIndexChanged(object sender, EventArgs e)
        {
            
            if (cmbnombrelector.SelectedItem is Lector lectorSeleccionado)
            {
                
                string nombre = lectorSeleccionado.nombre;

                
                Lector lectores = lector.FirstOrDefault(a => a.nombre == nombre);
                if (lector != null)
                {
                    
                    txtidlector.Text = lectores.id;
                    
                }
                else
                {
                    
                    txtidlector.Text = "";
                    
                }
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
            LectorArchivo lectoresArchivos = new LectorArchivo();
            lector = lectoresArchivos.Leer("../../lectores.json");

            
            if (lector != null && lector.Any())
            {
              
                cmbnombrelector.DataSource = lector;
                cmbnombrelector.DisplayMember = "nombre";  
                cmbnombrelector.ValueMember = "id";  
            }

            
            LibroArchivo librosArchivo = new LibroArchivo();
            libros = librosArchivo.Leer("../../libros.json");
            if (libros != null && libros.Any())
            {
               
                cmbnombrelibro.DataSource = libros;
                cmbnombrelibro.DisplayMember = "nombre";  
                cmbnombrelibro.ValueMember = "id";  
            }
        }

        private void cmbnombrelibro_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (cmbnombrelibro.SelectedItem is Libro libroSeleccionado)
            {

                string nombres = libroSeleccionado.nombre;


                Libro libross = libros.FirstOrDefault(a => a.nombre == nombres);
                if (lector != null)
                {

                    txtidlibro.Text = libross.id;
                    txtnombreautor.Text = libross.autor;
                }
                else
                {

                    txtidlibro.Text = "";
                    txtnombreautor.Text = "";
                }
            }
        }
        private void GuardarPrestamos()
        {
            try
            {
               
                string json = JsonConvert.SerializeObject(prestamos, Formatting.Indented);

                
                File.WriteAllText("../../prestamos.json", json);

                MessageBox.Show("Inscripción guardada correctamente.");
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar las inscripciones: {ex.Message}");
            }
        }
        private void btnguardar_Click(object sender, EventArgs e)
        {
            if (cmbnombrelector.SelectedItem is Lector lectorSeleccionado && cmbnombrelibro.SelectedItem is Libro libroSeleccionado)
            {
                
                Prestamos nuevoprestamo = new Prestamos
                {
                    idlector = lectorSeleccionado.id,
                    idlibro = libroSeleccionado.id
                };

               
                nuevoprestamo.fechaPrestamo = monthCalendar1.SelectionStart;

                
                prestamos.Add(nuevoprestamo);

                
                GuardarPrestamos();

                
                txtlibrosprestados.Text = prestamos.Count.ToString();
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un lector y un libro.");
            }
        }


        private void btnactualizar_Click(object sender, EventArgs e)
        {
            Mostrar();
        }
        private void Mostrar()
        {
            PrestamoArchivo prestamosArchivo = new PrestamoArchivo();
            prestamos = prestamosArchivo.Leer("../../prestamos.json");

            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prestamos;
            dataGridView1.Refresh();
        }
        private void button1_Click(object sender, EventArgs e)
        {
            
            var prestamosOrdenados = prestamos.OrderBy(p => p.fechaPrestamo).ToList();

            
            dataGridView1.DataSource = null;
            dataGridView1.DataSource = prestamosOrdenados;
            dataGridView1.Refresh();
        }

        private void btncerrar_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
