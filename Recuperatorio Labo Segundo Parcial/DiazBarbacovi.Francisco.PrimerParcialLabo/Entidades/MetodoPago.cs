using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades.Exceptions;

namespace Entidades
{
    public enum TarjetaTipo
    {
        MasterCard, Visa
    }

    public class MetodoPago
    {
        //TarjetaTipo tipoDeTarjeta;
        //string numeroDeTarjeta;

        //public TarjetaTipo TipoDeTarjeta { get => tipoDeTarjeta; set => tipoDeTarjeta = value; }
        //public string NumeroDeTarjeta { get => numeroDeTarjeta; set => numeroDeTarjeta = value; }

        //public MetodoPago()
        //{

        //}

        //public MetodoPago(TarjetaTipo tipo, string numero)
        //{
        //    tipoDeTarjeta = tipo;
        //    numeroDeTarjeta = numero;
        //}

        //public override string ToString()
        //{
        //    return $"{ConvertirTipo(tipoDeTarjeta)} finalizada en {InformarUltimosCuatroNumeros(numeroDeTarjeta)}";
        //}

        ///// <summary>
        ///// Convertidor de Enum.TarjetaTipo a string
        ///// </summary>
        ///// <param name="tipo"></param>
        ///// <returns></returns>
        //private string ConvertirTipo(TarjetaTipo tipo)
        //{
        //    if(tipo == TarjetaTipo.MasterCard)
        //    {
        //        return "Master Card";
        //    }

        //    return "Visa";
        //}

        ///// <summary>
        ///// Crea un metodo de pago a partir de un string, el cual va a ser parseado, y un Enum.TipoTarjeta
        ///// </summary>
        ///// <param name="numeroTarjeta"></param>
        ///// <param name="tipo"></param>
        ///// <returns></returns>
        //public static MetodoPago DevolverMetodoPago(string numeroTarjeta, TarjetaTipo tipo)
        //{
        //    try
        //    {
        //        if (numeroTarjeta.Length == 16)
        //        {
        //            long.Parse(numeroTarjeta);
        //            MetodoPago nuevoPago = new MetodoPago(tipo, numeroTarjeta);
        //            return nuevoPago;
        //        }
        //        throw new CantidadDeNumerosIncorrectoException();

        //    }
        //    catch (Exception)
        //    {
        //        throw;
        //    }
        //}

        ///// <summary>
        ///// Informa los cuatro ultimos caracteres del numero de tarjeta
        ///// </summary>
        ///// <param name="numero"></param>
        ///// <returns></returns>
        //private string InformarUltimosCuatroNumeros(string numero)
        //{
        //    string ultimosNumeros = string.Empty;

        //    ultimosNumeros += numero[numero.Length - 4];
        //    ultimosNumeros += numero[numero.Length - 3];
        //    ultimosNumeros += numero[numero.Length - 2];
        //    ultimosNumeros += numero[numero.Length - 1];

        //    return ultimosNumeros;
        //}

    }
}
