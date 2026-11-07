using BLL;
using Entity;

namespace UI;

public partial class Form1 : Form
{
    private AlquilerBusiness alquilerBusiness = new AlquilerBusiness();
    private TipoBicicletaBusiness tipoBicicletaBusiness = new TipoBicicletaBusiness();
    public Form1()
    {
        InitializeComponent();
    }

    private void btnAlta_Click(object sender, EventArgs e)
    {
        try
        {
            if (!decimal.TryParse(txtImporteTotal.Text.Trim(), out decimal importe))
            {
                MessageBox.Show("Por favor, ingrese un importe numérico válido.", "Dato Inválido", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (cbTipoBicicleta.SelectedValue == null)
            {
                MessageBox.Show("Debe seleccionar un tipo de bicicleta.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            Alquiler nuevo = new Alquiler
            {
                IdTipoBicicleta = Convert.ToInt32(cbTipoBicicleta.SelectedValue),
                DniCliente = txtDniCliente.Text.Trim(),
                ImporteTotal = importe,
                FechaAlquiler = dtpFechaAlquiler.Value
            };

            alquilerBusiness.guardarAlquiler(nuevo);

            MessageBox.Show("Alquiler registrado con éxito.", "Operación Exitosa", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtDniCliente.Clear();
            txtImporteTotal.Clear();
            cbTipoBicicleta.SelectedIndex = -1;
            dtpFechaAlquiler.Value = DateTime.Today;

            ActualizarGrilla();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error de Validación", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }

    }

    private void Form1_Load(object sender, EventArgs e)
    {
        CargarTiposBicicleta();
        ActualizarGrilla();
    }

    private void CargarTiposBicicleta()
    {
        cbTipoBicicleta.DataSource = tipoBicicletaBusiness.getAll();
        cbTipoBicicleta.DisplayMember = "Descripcion";
        cbTipoBicicleta.ValueMember = "IdTipoBicicleta";
    }

    private void ActualizarGrilla()
    {
        try
        {
            dgvAlquileres.DataSource = null;
            dgvAlquileres.DataSource = alquilerBusiness.getAll();
        }
        catch (Exception ex)
        {
            MessageBox.Show("Error al actualizar la grilla: " + ex.Message, "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEliminar_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtIdEliminar.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un número de ID válido para eliminar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DialogResult confirmacion = MessageBox.Show(
                $"¿Está seguro de que desea eliminar el alquiler con ID {id}?",
                "Confirmar eliminación",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question
            );

            if (confirmacion == DialogResult.Yes)
            {
                alquilerBusiness.eliminarAlquiler(id);

                MessageBox.Show("Alquiler eliminado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                txtIdEliminar.Clear();
                ActualizarGrilla();
            }
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error al eliminar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }

    private void btnEditar_Click(object sender, EventArgs e)
    {
        try
        {
            if (!int.TryParse(txtIdModificar.Text.Trim(), out int id))
            {
                MessageBox.Show("Ingrese un número de ID válido para modificar.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            if (!decimal.TryParse(txtNuevoImporte.Text.Trim(), out decimal nuevoImporte))
            {
                MessageBox.Show("Ingrese un importe numérico válido.", "Atención", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }

            DateTime nuevaFecha = dtpNuevaFecha.Value;

            alquilerBusiness.modificarAlquiler(id, nuevaFecha, nuevoImporte);

            MessageBox.Show("Alquiler modificado correctamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);

            txtIdModificar.Clear();
            txtNuevoImporte.Clear();
            ActualizarGrilla();
        }
        catch (Exception ex)
        {
            MessageBox.Show(ex.Message, "Error al modificar", MessageBoxButtons.OK, MessageBoxIcon.Error);
        }
    }
}
