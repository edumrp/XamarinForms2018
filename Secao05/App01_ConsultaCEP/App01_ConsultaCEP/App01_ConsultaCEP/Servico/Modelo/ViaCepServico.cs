﻿using System;
using System.Collections.Generic;
using System.Net;
using System.Text;
using App01_ConsultaCEP.Servico.Modelo;
using Newtonsoft.Json;

namespace App01_ConsultaCEP.Servico.Modelo
{
    public class ViaCepServico
    {
        private static string EnderecoURL = "http://viacep.com.br/ws/{0}/json/";

        public static Endereco BuscarEnderecoViaCEP(string cep)
        {
            string novoEnderecoURL = string.Format(EnderecoURL, cep);

            WebClient wc = new WebClient();
            string conteudo = wc.DownloadString(novoEnderecoURL);

            Endereco end = JsonConvert.DeserializeObject<Endereco>(conteudo);

            return end;
        }
    }
}
