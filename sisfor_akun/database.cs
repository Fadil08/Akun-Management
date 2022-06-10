using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Npgsql;

namespace sisfor_akun
{
    public abstract class Database
    {
        public NpgsqlConnection conn;
        public string query;
        public string connstr;
        public Database(string query)
        {
            conn = new NpgsqlConnection("Server=localhost;Port=5432;User Id=postgres;Password=123;Database=projekpbo;");
            this.query = query;
        }
        public abstract void ExecQuery();
        public abstract void ExecReader(DataGridView dgv, DataTable dt);
    }
    class SQLDBHelper : Database
    {
        public SQLDBHelper(string query) : base(query) { this.query = query; }
        public override void ExecQuery()
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            cmd.ExecuteNonQuery();
            conn.Close();
            cmd.Dispose();
        }
        public override void ExecReader(DataGridView dgv, DataTable dt)
        {
            conn.Open();
            NpgsqlCommand cmd = new NpgsqlCommand(query, conn);
            NpgsqlDataReader dr = cmd.ExecuteReader();
            dt.Load(dr);
            dgv.DataSource = dt;
            conn.Close();
            cmd.Dispose();

        }
    }
}
