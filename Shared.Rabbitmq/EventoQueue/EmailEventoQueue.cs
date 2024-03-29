﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Shared.Rabbitmq.Eventos;

namespace Shared.Rabbitmq.EventoQueue
{
    public class EmailEventoQueue : Evento
    {
        public string Destinatario { get; set; }    
        public string Titulo { get; set; }   
        public string Contenido { get; set; }   

        public EmailEventoQueue(string destinatario, string titulo, string contenido)
        {
            Destinatario = destinatario;    
            Titulo = titulo;    
            Contenido = contenido;  
        }



    } 
}
