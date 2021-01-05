using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using SqlSugar;

namespace me.cqp.luohuaming.qa.Code
{
    public static class SQLHelper
    {
        static string DBPath { get; set; }
        public static void Init(string DBPath)
        {
            SQLHelper.DBPath = DBPath;
        }
        private static SqlSugarClient GetInstance()
        {
            SqlSugarClient db = new SqlSugarClient(new ConnectionConfig()
            {
                ConnectionString = $"data source={DBPath}",
                DbType = DbType.Sqlite,
                IsAutoCloseConnection = true,
                InitKeyType = InitKeyType.Attribute,
            });
            return db;
        }
        public static List<OrderModel> GetAllOrder()
        {
            using(var db = GetInstance())
            {
                var result = db.UseTran(() =>
                {
                    return db.Queryable<OrderModel>().Where(x => true).ToList();
                });
                if (result.IsSuccess)
                {
                    return result.Data;
                }
                else
                {
                    return null;
                }
            }
        }
    }
}
