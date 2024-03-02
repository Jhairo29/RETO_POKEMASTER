using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Data;
using System.Linq;
using System.Web;
using WebAPI.Models;

namespace WebAPI.Data
{
    public class PokemonData
    {
        public static bool Registrar(Pokemon oPokemon)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_registrar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@nombre", oPokemon.Nombre);
                cmd.Parameters.AddWithValue("@tipo", oPokemon.Tipo);
                cmd.Parameters.AddWithValue("@alimentacion", oPokemon.Alimentacion);
                cmd.Parameters.AddWithValue("@tamaño", oPokemon.Tamaño);
                cmd.Parameters.AddWithValue("@peso", oPokemon.Peso);
                cmd.Parameters.AddWithValue("@rareza", oPokemon.Rareza);
                cmd.Parameters.AddWithValue("@dato_curioso", oPokemon.DatoCurioso);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static bool Modificar(Pokemon oPokemon)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_modificar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpokemon", oPokemon.IdPokemon);
                cmd.Parameters.AddWithValue("@nombre", oPokemon.Nombre);
                cmd.Parameters.AddWithValue("@tipo", oPokemon.Tipo);
                cmd.Parameters.AddWithValue("@alimentacion", oPokemon.Alimentacion);
                cmd.Parameters.AddWithValue("@tamaño", oPokemon.Tamaño);
                cmd.Parameters.AddWithValue("@peso", oPokemon.Peso);
                cmd.Parameters.AddWithValue("@rareza", oPokemon.Rareza);
                cmd.Parameters.AddWithValue("@dato_curioso", oPokemon.DatoCurioso);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
        public static List<Pokemon> Listar()
        {
            List<Pokemon> oListaPokemon = new List<Pokemon>();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_listar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oListaPokemon.Add(new Pokemon()
                            {
                                IdPokemon = Convert.ToInt32(dr["IdPokemon"]),
                                Nombre = dr["Nombre"].ToString(),
                                Tipo = dr["Tipo"].ToString(),
                                Alimentacion = dr["Alimentacion"].ToString(),
                                Tamaño = dr["Tamaño"].ToString(),
                                Peso = dr["Peso"].ToString(),
                                Rareza = dr["Rareza"].ToString(),
                                DatoCurioso = dr["DatoCurioso"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            });
                        }
                    }
                    return oListaPokemon;
                }
                catch (Exception ex)
                {
                    return oListaPokemon;
                }
            }
        }
        public static Pokemon Obtener(int idpokemon)
        {
            Pokemon oPokemon = new Pokemon();
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_obtener", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpokemon", idpokemon);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();

                    using (SqlDataReader dr = cmd.ExecuteReader())
                    {
                        while (dr.Read())
                        {
                            oPokemon = new Pokemon()
                            {
                                IdPokemon = Convert.ToInt32(dr["IdPokemon"]),
                                Nombre = dr["Nombre"].ToString(),
                                Tipo = dr["Tipo"].ToString(),
                                Alimentacion = dr["Alimentacion"].ToString(),
                                Tamaño = dr["Tamaño"].ToString(),
                                Peso = dr["Peso"].ToString(),
                                Rareza = dr["Rareza"].ToString(),
                                DatoCurioso = dr["DatoCurioso"].ToString(),
                                FechaRegistro = Convert.ToDateTime(dr["FechaRegistro"].ToString())
                            };
                        }
                    }
                    return oPokemon;
                }
                catch (Exception ex)
                {
                    return oPokemon;
                }
            }
        }
        public static bool Eliminar(int id)
        {
            using (SqlConnection oConexion = new SqlConnection(Conexion.rutaConexion))
            {
                SqlCommand cmd = new SqlCommand("usp_eliminar", oConexion);
                cmd.CommandType = CommandType.StoredProcedure;
                cmd.Parameters.AddWithValue("@idpokemon", id);

                try
                {
                    oConexion.Open();
                    cmd.ExecuteNonQuery();
                    return true;
                }
                catch (Exception ex)
                {
                    return false;
                }
            }
        }
    }
}