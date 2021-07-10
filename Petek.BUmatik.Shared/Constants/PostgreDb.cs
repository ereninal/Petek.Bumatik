using System;
using System.Collections.Generic;
using System.Text;

namespace Petek.BUmatik.Shared.Constants
{
    public static class PostgreDb
    {
        public static string ConnectionStringLocal = "User ID=postgres;Password=W{h9qXLa5<72w8;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security=true;Pooling=true;";
        public static string ConnectionStringTest = "User ID=postgres;Password=1;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security = true; Pooling=true;";
        public static string ConnectionStringProd = "User ID=postgres;Password=1;Server=127.0.0.1;Port=5432;Database=BUmatik;Integrated Security = true; Pooling=true;";
    }
}
