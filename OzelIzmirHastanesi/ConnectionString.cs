﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace ozelizmirhastanesii
{
    class ConnectionString
    {
        public SqlConnection GetCon()
        {
            SqlConnection baglanti = new SqlConnection();

            baglanti.ConnectionString = "Data Source=(LocalDB)\\MSSQLLocalDB;AttachDbFilename=\"C:\\Users\\deniz\\OneDrive - BAKIRÇAY ÜNİVERSİTESİ\\Belgeler\\HospitalDb.mdf\";Integrated Security=True;Connect Timeout=30;Encrypt=True";
            return baglanti;
        }
    }
}