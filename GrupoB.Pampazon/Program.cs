using GrupoB.Pampazon.AcondicionarYEmpaquetarLote;
using GrupoB.Pampazon.Almacenes;
using GrupoB.Pampazon.DespachoCargaTransporte;
using GrupoB.Pampazon.EmitirOrdenDeEntrega;
using GrupoB.Pampazon.RegistrarMermasEIncidencias;

namespace GrupoB.Pampazon
{
    internal static class Program
    {
        /// <summary>
        ///  The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            // To customize application configuration such as set high DPI settings or default font,
            // see https://aka.ms/applicationconfiguration.
            ApplicationConfiguration.Initialize();
            Application.Run(new EmitirOrdenDeSeleccionForm());

            OrdenDeEntregaAlmacen.Guardar();
            OrdenDePreparacionAlmacen.Guardar();
            ClienteAlmacen.Guardar();
            InventarioAlmacen.Guardar();
            IncidenciaMermaAlmacen.Guardar();
            OrdenDeSeleccionAlmacen.Guardar();
            ProductoAlmacen.Guardar();

        }
    }
}