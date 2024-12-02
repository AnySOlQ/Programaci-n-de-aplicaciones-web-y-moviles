using System;

namespace InyeccionDependenciasEjemplo
{
    // 1. Definimos la interfaz de servicio de mensajería
    public interface IMensajeServicio
    {
        void EnviarMensaje(string destinatario, string contenido);
    }

    // 2. Implementación para enviar correos electrónicos
    public class CorreoElectronicoServicio : IMensajeServicio
    {
        public void EnviarMensaje(string destinatario, string contenido)
        {
            Console.WriteLine($"Enviando correo a {destinatario}: {contenido}");
        }
    }

    // 3. Implementación para enviar SMS
    public class SmsServicio : IMensajeServicio
    {
        public void EnviarMensaje(string destinatario, string contenido)
        {
            Console.WriteLine($"Enviando SMS a {destinatario}: {contenido}");
        }
    }

    // 4. Clase que usa el servicio para enviar notificaciones
    public class Notificador
    {
        private readonly IMensajeServicio _mensajeServicio;

        // Inyectamos la dependencia en el constructor
        public Notificador(IMensajeServicio mensajeServicio)
        {
            _mensajeServicio = mensajeServicio;
        }

        public void Notificar(string destinatario, string mensaje)
        {
            _mensajeServicio.EnviarMensaje(destinatario, mensaje);
        }
    }

    // 5. Programa principal que usa la inyección de dependencias
    class Program
    {
        static void Main(string[] args)
        {
            // Usamos el servicio de correo electrónico
            IMensajeServicio servicioCorreo = new CorreoElectronicoServicio();
            Notificador notificador = new Notificador(servicioCorreo);
            notificador.Notificar("ana@example.com", "¡Hola Ana!");

            // También podríamos usar el servicio de SMS
            IMensajeServicio servicioSms = new SmsServicio();
            Notificador notificadorSms = new Notificador(servicioSms);
            notificadorSms.Notificar("1234567890", "¡Hola! Este es un SMS.");
        }
    }
}
