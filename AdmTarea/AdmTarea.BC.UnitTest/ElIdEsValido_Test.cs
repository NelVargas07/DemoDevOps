using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using AdmTarea.BC.Modelos;
using AdmTarea.BC.ReglasDeNegocio;

namespace AdmTarea.BC.UnitTest
{
    [TestClass]
    public class ElIdEsValido_Test
    {
        private (bool, string) resultadoEsperado;
        private (bool, string) resultadoObtenido;

        [TestMethod]
        [TestCategory("La tarea debe contener un id valido")]
        [TestCategory("La tarea es valida")]

        public void LaTareaDebeConteneruUnIdValido_LaTareaEsValida_EsValida()
        {
            Tarea tarea = DatosDePruebaID.Tarea();

            resultadoEsperado = (true, string.Empty);

            resultadoObtenido = ReglasTarea.ElIdEsValido(tarea.id);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
