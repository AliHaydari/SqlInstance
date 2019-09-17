using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Sql;
using System.Data.SqlClient;

namespace SqlInstance.Helpers
{
    public static class DbHelpers
    {
        public static List<string> FindNetworkSqlInstances()
        {
            string myServer = Environment.MachineName;
            var srv = new List<string>();
            DataTable servers = SqlDataSourceEnumerator.Instance.GetDataSources();
            for (int i = 0; i < servers.Rows.Count; i++)
            {
                //if (myServer == servers.Rows[i]["ServerName"].ToString()) ///// used to get the servers in the local machine////
                {
                    if ((servers.Rows[i]["InstanceName"] as string) != null)
                        srv.Add(servers.Rows[i]["ServerName"] + "\\" + servers.Rows[i]["InstanceName"]);
                    else
                        srv.Add(servers.Rows[i]["ServerName"].ToString());
                }
            }

            return srv;
        }

        public static List<string> FindLocaleSqlInstances()
        {
            var srv = new List<string>();
            RegistryView registryView = Environment.Is64BitOperatingSystem ? RegistryView.Registry64 : RegistryView.Registry32;
            using (RegistryKey hklm = RegistryKey.OpenBaseKey(RegistryHive.LocalMachine, registryView))
            {
                RegistryKey instanceKey = hklm.OpenSubKey(@"SOFTWARE\Microsoft\Microsoft SQL Server\Instance Names\SQL", false);
                if (instanceKey != null)
                {
                    foreach (var instanceName in instanceKey.GetValueNames())
                    {
                        srv.Add(Environment.MachineName + @"\" + instanceName);
                    }
                }
            }

            return srv;
        }

        public static List<string> GetAllDataBases(string dataSource, string userId, string password)
        {
            try
            {
                List<string> list = new List<string>();

                string conStringPart1 = $"server={dataSource};uid={userId};pwd={password};";
                string conStringPart2 = "database=master";
                string conString = conStringPart1 + conStringPart2;

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //var dbName = dr[0].ToString();
                                //if (!dbName.StartsWith("Hatra_"))
                                //{
                                //    continue;
                                //}

                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                }

                return list;

                //var dataBaseViewModels = new List<DataBaseViewModel>();

                //foreach (var dbn in list)
                //{
                //    var dataBaseViewModel = new DataBaseViewModel();

                //    try
                //    {
                //        dataBaseViewModel.DbName = dbn;

                //        var conStr = conStringPart1 + $"database={dbn}";
                //        using (SqlConnection con = new SqlConnection(conStr))
                //        {
                //            con.Open();

                //            using (SqlCommand cmd = new SqlCommand("SELECT ID,Name,EconomicCode,Email,Tel,City,Country,Address,RegistrationNumber from tblCompany", con))
                //            {
                //                using (IDataReader dr = cmd.ExecuteReader())
                //                {
                //                    while (dr.Read())
                //                    {
                //                        dataBaseViewModel.CompanyId = (Guid)dr[0];
                //                        dataBaseViewModel.CompanyName = (string)dr[1];
                //                        dataBaseViewModel.CompanyEconomicCode = (string)dr[2];
                //                        dataBaseViewModel.CompanyEmail = (string)dr[3];
                //                        dataBaseViewModel.CompanyTel = (string)dr[4];
                //                        dataBaseViewModel.CompanyCity = (string)dr[5];
                //                        dataBaseViewModel.CompanyCountry = (string)dr[6];
                //                        dataBaseViewModel.CompanyAddress = (string)dr[7];
                //                        dataBaseViewModel.CompanyRegistrationNumber = (string)dr[8];
                //                    }
                //                }
                //            }

                //            using (SqlCommand cmd = new SqlCommand("SELECT ID,Name,StartDate,EndDate from tblFinancialYear", con))
                //            {
                //                using (IDataReader dr = cmd.ExecuteReader())
                //                {
                //                    while (dr.Read())
                //                    {
                //                        dataBaseViewModel.FinancialYearId = (Guid)dr[0];
                //                        dataBaseViewModel.FinancialYearName = (string)dr[1];
                //                        dataBaseViewModel.FinancialYearStartDate = (int)dr[2];
                //                        dataBaseViewModel.FinancialYearEndDate = (int)dr[3];
                //                    }
                //                }
                //            }
                //        }

                //        dataBaseViewModels.Add(dataBaseViewModel);
                //    }
                //    catch (Exception e)
                //    {
                //        continue;
                //    }
                //}

                //return dataBaseViewModels;
            }
            catch (Exception e)
            {
                return new List<string>();
            }
        }

        public static List<string> GetAllDataBases(string dataSource)
        {
            try
            {
                List<string> list = new List<string>();

                string conStringPart1 = $"server={dataSource};";
                string conStringPart2 = "database=master";
                string conString = conStringPart1 + conStringPart2;

                using (SqlConnection con = new SqlConnection(conString))
                {
                    con.Open();
                    using (SqlCommand cmd = new SqlCommand("SELECT name from sys.databases", con))
                    {
                        using (IDataReader dr = cmd.ExecuteReader())
                        {
                            while (dr.Read())
                            {
                                //var dbName = dr[0].ToString();
                                //if (!dbName.StartsWith("Hatra_"))
                                //{
                                //    continue;
                                //}

                                list.Add(dr[0].ToString());
                            }
                        }
                    }
                }

                return list;
            }
            catch (Exception e)
            {
                return new List<string>();
            }
        }
    }
}
