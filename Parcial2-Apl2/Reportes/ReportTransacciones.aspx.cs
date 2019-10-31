using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using BLL;
using Entidades;
using Microsoft.Reporting.WebForms;
using Parcial2_Apl2.Consultas;

namespace Parcial2_Apl2.Reportes
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            CTrasacciones cTransacciones = new CTrasacciones();
            if (!Page.IsPostBack)
            {
                RepositorioBase<Transacciones> repositorio = new RepositorioBase<Transacciones>();
                var lista = repositorio.GetList(x => true);

                MyReportViewer.ProcessingMode = Microsoft.Reporting.WebForms.ProcessingMode.Local;
                MyReportViewer.Reset();


                MyReportViewer.LocalReport.ReportPath = Server.MapPath(@"~\Reportes\ListadoTransacciones.rdlc");

                MyReportViewer.LocalReport.DataSources.Add(new ReportDataSource("DataSet1", lista));

                MyReportViewer.LocalReport.Refresh();
            }

        }
    }
}