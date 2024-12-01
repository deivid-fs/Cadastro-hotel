using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Runtime.ConstrainedExecution;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using static System.Runtime.InteropServices.JavaScript.JSType;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.ListView;

namespace GestaoHotel
{
    internal class HotelDAO
    {
        //declarando uma variavel estatica
        static string conexao = "server=localhost;database=hoteldb;uid=root;pwd='';";

        //Metodo para criacao (insert) de um hotel
        public static void Criar(string nome_hotel, string nome_gerente, 
            string cnpj, string insc_est, string endereco, string numero, 
            string bairro, string cidade, string uf, string cep, 
            string telefone_fixo, string telefone_celular, string email)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"INSERT INTO hotel(
                        nome_hotel, 
                        nome_gerente, 
                        cnpj, 
                        insc_esc, 
                        endereco, 
                        numero, 
                        bairro, 
                        cidade, 
                        uf,
                        cep, 
                        telefone_fixo, 
                        telefone_celular, 
                        email
                 ) VALUES (
                        @nome_hotel, 
                        @nome_gerente, 
                        @cnpj, 
                        @insc_est, 
                        @endereco, 
                        @numero, 
                        @bairro, 
                        @cidade, 
                        @uf,
                        @cep, 
                        @telefone_fixo, 
                        @telefone_celular, 
                        @email
                 )";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn)) {
                    cmd.Parameters.AddWithValue("@nome_hotel", nome_hotel);
                    cmd.Parameters.AddWithValue("@nome_gerente", nome_gerente);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@insc_Est", insc_est);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@telefone_fixo", telefone_fixo);
                    cmd.Parameters.AddWithValue("@telefone_celular", telefone_celular);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        //Metodo (rotina) para atualizar o cadastro do hotel
        public static void Atualizar(string id,string nome_hotel, string nome_gerente,
    string cnpj, string insc_est, string endereco, string numero,
    string bairro, string cidade, string uf, string cep,
    string telefone_fixo, string telefone_celular, string email)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"update hotel set
                        nome_hotel = @nome_hotel, 
                        nome_gerente = @nome_gerente, 
                        cnpj = @cnpj, 
                        insc_esc = @insc_est, 
                        endereco = @endereco, 
                        numero = @numero, 
                        bairro = @bairro, 
                        cidade = @cidade, 
                        uf = @uf,
                        cep = @cep, 
                        telefone_fixo = @telefone_fixo, 
                        telefone_celular = @telefone_celular, 
                        email = @email
                         where id = @id";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@nome_hotel", nome_hotel);
                    cmd.Parameters.AddWithValue("@nome_gerente", nome_gerente);
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    cmd.Parameters.AddWithValue("@insc_Est", insc_est);
                    cmd.Parameters.AddWithValue("@endereco", endereco);
                    cmd.Parameters.AddWithValue("@numero", numero);
                    cmd.Parameters.AddWithValue("@bairro", bairro);
                    cmd.Parameters.AddWithValue("@cidade", cidade);
                    cmd.Parameters.AddWithValue("@uf", uf);
                    cmd.Parameters.AddWithValue("@cep", cep);
                    cmd.Parameters.AddWithValue("@telefone_fixo", telefone_fixo);
                    cmd.Parameters.AddWithValue("@telefone_celular", telefone_celular);
                    cmd.Parameters.AddWithValue("@email", email);
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        //Metodo para excluir o cadastro de um hotel
        public static void Deletar(string id)
        {
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"delete from hotel(
                       where id = @id";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    cmd.ExecuteNonQuery();
                }

                conn.Close();
            }
        }

        //Metodo (rotina) para listar o cadastro de um hotel
        public static DataTable Listar()
        {
            DataTable dados = new DataTable("dados");
            
            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"SELECT ID, 
                        nome_hotel, 
                        nome_gerente, 
                        cnpj, 
                        insc_esc, 
                        endereco, 
                        numero, 
                        bairro, 
                        cidade, 
                        uf,
                        cep, 
                        telefone_fixo, 
                        telefone_celular, 
                        email
                    FROM hotel";

                conn.Open();
                
                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        dados.Load(reader);
                }

                conn.Close();
            }

            return dados;
        }
        
        //Rotina para localizar o cadastro de um hotel
        public static DataTable LocalizarPorCodigo(string id)
        {
            DataTable dados = new DataTable("dados");

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"SELECT ID, 
                        nome_hotel, 
                        nome_gerente, 
                        cnpj, 
                        insc_esc, 
                        endereco, 
                        numero, 
                        bairro, 
                        cidade, 
                        uf,
                        cep, 
                        telefone_fixo, 
                        telefone_celular, 
                        email
                    FROM hotel where id =@id";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@id", id);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        dados.Load(reader);
                }

                conn.Close();
            }

            return dados;

        }

        public static DataTable localizarPorcnpj(string cnpj)
        {
            DataTable dados = new DataTable("dados");

            using (MySqlConnection conn = new MySqlConnection(conexao))
            {
                string sql = @"SELECT ID, 
                        nome_hotel, 
                        nome_gerente, 
                        cnpj, 
                        insc_esc, 
                        endereco, 
                        numero, 
                        bairro, 
                        cidade, 
                        uf,
                        cep, 
                        telefone_fixo, 
                        telefone_celular, 
                        email
                    FROM hotel where cnpj = @cnpj";

                conn.Open();

                using (MySqlCommand cmd = new MySqlCommand(sql, conn))
                {
                    cmd.Parameters.AddWithValue("@cnpj", cnpj);
                    using (MySqlDataReader reader = cmd.ExecuteReader())
                        dados.Load(reader);
                }

                conn.Close();
            }

            return dados;
        }



    }
}
