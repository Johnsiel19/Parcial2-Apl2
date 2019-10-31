using Microsoft.VisualStudio.TestTools.UnitTesting;
using BLL;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;

namespace BLL.Tests
{
    [TestClass()]
    public class RepositorioBaseTests
    {
        [TestMethod()]
        public void GuardarTest()
        {
            Transacciones trasacciones = new Transacciones();
            trasacciones.TransaccionId = 2;
            trasacciones.Tipo = "Pago";
            trasacciones.Fecha = DateTime.Now;
            trasacciones.Monto = 1000;

            RepositorioBase<Transacciones> db = new RepositorioBase<Transacciones>();

            Assert.IsTrue(db.Guardar(trasacciones));



        }

        [TestMethod()]
        public void ModificarTest()
        {
            Transacciones trasacciones = new Transacciones();
            trasacciones.TransaccionId = 1;
            trasacciones.Tipo = "Venta";
            trasacciones.Fecha = DateTime.Now;
            trasacciones.Monto = 100;


            RepositorioBase<Transacciones> db = new RepositorioBase<Transacciones>();

            Assert.IsTrue(db.Modificar(trasacciones));
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Transacciones> db = new RepositorioBase<Transacciones>();
            Assert.IsTrue(db.Eliminar(1));


        }


        [TestMethod()]
        public void GuardarTest2()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = 2;
            cliente.Nombre = "Johnsiel";
            cliente.Balance = 1000;

            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Assert.IsTrue(db.Guardar(cliente));



        }

        [TestMethod()]
        public void ModificarTest2()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.Nombre = "juan";
            cliente.Balance = 1000;

            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Assert.IsTrue(db.Modificar(cliente));
        }

        [TestMethod()]
        public void EliminarTest2()
        {
            RepositorioBase<Clientes> db = new RepositorioBase<Clientes>();
            Assert.IsTrue(db.Eliminar(1));
        }
    }
}