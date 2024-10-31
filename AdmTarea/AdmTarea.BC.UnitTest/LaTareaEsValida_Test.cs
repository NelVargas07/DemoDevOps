
using AdmTarea.BC.Modelos;
using AdmTarea.BC.ReglasDeNegocio;

namespace AdmTarea.BC.UnitTest
{
    [TestClass]
    public class LaTareaEsValida_Test
    {
        private (bool, string) resultadoEsperado;
        private (bool, string) resultadoObtenido;

        [TestMethod]
        [TestCategory("La tarea debe contener la informacion valida")]
        [TestCategory("La tarea es valida")]

        public void LaTareaDebeContenerLaInformacionValida_LaTareaEsValida_EsValida()
        {
            Tarea tarea = DatosDePrueba.Tarea();

            resultadoEsperado = (true,string.Empty);   

            resultadoObtenido = ReglasTarea.LaTareaEsValida(tarea);

            Assert.AreEqual(resultadoEsperado,resultadoObtenido);
        }

        [TestMethod]
        [TestCategory("La tarea debe contener la informacion valida")]
        [TestCategory("El nombre es nulo")]

        public void LaTareaDebeContenerLaInformacionValida_ElNombreEsNulo_NoEsValida()
        {
            Tarea tarea = DatosDePrueba.Tarea();

            tarea.nombre = null;

            resultadoEsperado = (true, "La tarea no es valida");

            resultadoObtenido = ReglasTarea.LaTareaEsValida(tarea);

            Assert.AreEqual(resultadoEsperado, resultadoObtenido);
        }
    }
}
