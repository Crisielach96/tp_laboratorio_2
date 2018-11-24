using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Threading;

namespace Entidades
{
    public class Paquete : IMostrar<Paquete>
    {

        EEstado estado;
        string direccionEntrega;
        string trackingID;
        
        public string DireccionEntrega
        {
            get { return this.direccionEntrega; }
            set { direccionEntrega = value; }
        }
        public EEstado Estado
        {
            get { return this.estado; }
            set { estado = value; }
        }
        public string TrackingID
        {
            get { return this.trackingID; }
            set { trackingID = value; }
        }
       
        public delegate void DelegadoEstado(object sender, EventArgs e);
        public event DelegadoEstado InformarEstado;

        public void MockCicloDeVida()
        {
            while (this.Estado != EEstado.Entregado)
            {
                try
                {
                    Thread.Sleep(4000);
                }
                catch (Exception e)
                {
                    Console.WriteLine(e.Message);
                }
                
                switch (this.Estado)
                {
                    case EEstado.Ingresado:
                        this.Estado = EEstado.EnViaje;
                        this.InformarEstado(this, new EventArgs());
                        break;
                    case EEstado.EnViaje:
                        this.Estado = EEstado.Entregado;
                        this.InformarEstado(this, new EventArgs());
                        break;
                    default:
                        break;
                }
            }
            try
            {
                PaqueteDAO.Insertar(this);
            }
            catch (Exception e)
            {
                this.InformarEstado(e, new EventArgs());
            }

        }
        
        public static bool operator ==(Paquete p1, Paquete p2)
        {
            bool retorno = false;

            if (p1.TrackingID == p2.TrackingID)
            {
                retorno = true;
            }
            return retorno;
        }
        
        public static bool operator !=(Paquete p1, Paquete p2)
        {
            return !(p1 == p2);
        }
        
        public string MostrarDatos(IMostrar<Paquete> elemento)
        {
            Paquete p = (Paquete)elemento;
            StringBuilder sb = new StringBuilder();
            sb.AppendFormat("{0} para la direccion: {1}", p.TrackingID, p.DireccionEntrega);
            return sb.ToString();
        }
        
        public override string ToString()
        {
            return MostrarDatos(this);
        }
        
        public Paquete(string direccionEntrega,string trackingID)
        {
            this.DireccionEntrega = direccionEntrega;
            this.TrackingID = trackingID;
            this.Estado = EEstado.Ingresado;
        }

        public enum EEstado
        {
            Ingresado,
            EnViaje,
            Entregado
        }
    }
}

