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
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.Nombre = "Johnsiel";
            cliente.Balance = 1000;

            RepositorioBase<Clientes> r = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = r.Guardar(cliente);
            Assert.AreEqual(true, paso);



        }

        [TestMethod()]
        public void ModificarTest()
        {
            Clientes cliente = new Clientes();
            cliente.ClienteId = 1;
            cliente.Nombre = "juan";
            cliente.Balance = 1000;

            RepositorioBase<Clientes> r = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = r.Modificar(cliente);
            Assert.AreEqual(true, paso);
        }

        [TestMethod()]
        public void EliminarTest()
        {
            RepositorioBase<Clientes> repositoriobase = new RepositorioBase<Clientes>();
            bool paso = false;
            paso = repositoriobase.Eliminar(1);
            Assert.AreEqual(true, paso);
        }

     
    }
}