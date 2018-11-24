using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{

    public class Correo : IMostrar<List<Paquete>>
    {
        List<Thread> MockPaquetes;
        List<Paquete> paquetes;

        public List<Paquete> Paquetes
        {
            get { return paquetes; }
            set { paquetes = value; }
        }

        public Correo()
        {
            MockPaquetes = new List<Thread>();
            paquetes = new List<Paquete>();
        }

        public void FinEntregas()
        {
            foreach (Thread t in this.MockPaquetes)
            {
                if (t.IsAlive)
                    t.Abort();
            }
        }

        public static Correo operator +(Correo c, Paquete p)
        {
            foreach (Paquete item in c.Paquetes)
            {
                if (item == p)
                {
                    throw new TrakingIdRepetidoException("El ID ya existe.");
                }

            }
            Thread hiloMock = new Thread(p.MockCicloDeVida);
            c.Paquetes.Add(p);
            c.MockPaquetes.Add(hiloMock);
            hiloMock.Start();

            return c;
        }

        public string MostrarDatos(IMostrar<List<Paquete>> elementos)
        {
            StringBuilder sb = new StringBuilder();
            if (elementos.GetType() == typeof(Correo))
            {
                foreach (Paquete p in ((Correo)elementos).Paquetes)
                {
                    sb.AppendFormat("El tracking: {0}. Para la direccion: {1} (En estado: {2}) \n", p.TrackingID, p.DireccionEntrega, p.Estado.ToString());
                }
            }
            return sb.ToString();
        }


    }
}
