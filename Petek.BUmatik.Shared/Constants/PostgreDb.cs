using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.Constants
{
    public static class PostgreDb
    {
        //public static string ConnectionStringLocal = "User ID=postgres;Password=W{h9qXLa5<72w8;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security=true;Pooling=true;";
        public static string ConnectionStringLocal = "User ID=postgres;Password=1;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security=true;Pooling=true;";
        public static string ConnectionStringTest = "User ID=ylaiterhmzglgk;Password=f664ac6e0916049c01c3f0f60caaaf314469be40708ae469f43e830d58dbc8e5;Server=ec2-54-220-195-236.eu-west-1.compute.amazonaws.com;Port=5432;Database=ddtg3g197jfg0m;Integrated Security=false;Pooling=true;sslmode=Require;Trust Server Certificate=true;";
        public static string ConnectionStringProd = "User ID=postgres;Password=1;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security = true; Pooling=true;";
    }
}
