using System;
using System.Collections.Generic;
using System.Windows.Forms;
using System.Data;

namespace Print
{
    static class Program
    {
        /// <summary>
        /// 应用程序的主入口点。
        /// </summary>
        [STAThread]
        static void Main()
        {

            //使用模板前必须开启模板功能|让模板初始化
            PrintThemp.EditTemplateInfo.LoadEdit = true;
            //单套打印
            PrintThemp.EditTemplateInfo.IsMuch = false;

            //给模板数据源|EditTemplateDataSource:单套或EditTemplateDSCollection:多套

            #region DataTable
            DataTable contract = new DataTable("Contract");
            contract.Columns.Add("buyEnterpriseZh", typeof(string));
            contract.Columns.Add("buyEnterpriseEn", typeof(string));
            contract.Columns.Add("contractNumEn", typeof(string));
            contract.Columns.Add("contractNum", typeof(string));
            contract.Columns.Add("sellEnterpriseZh", typeof(string));
            contract.Columns.Add("sellEnterpriseEn", typeof(string));
            contract.Columns.Add("originArea", typeof(string));
            contract.Columns.Add("originAreaEn", typeof(string));
            contract.Columns.Add("packEn", typeof(string));
            contract.Columns.Add("pack", typeof(string));
            contract.Columns.Add("shipDate", typeof(string));
            contract.Columns.Add("shipArea", typeof(string));
            contract.Columns.Add("destination", typeof(string));
            contract.Columns.Add("tradeLanguage", typeof(string));
            contract.Columns.Add("payment", typeof(string));
            contract.Columns.Add("contractDate", typeof(string));
            contract.Columns.Add("massRequrie", typeof(string));
            contract.Columns.Add("buyer", typeof(string));
            contract.Columns.Add("sheller", typeof(string));
            DataRow row = contract.NewRow();
            row["buyEnterpriseZh"] = "江苏南京红心集团";
            row["buyEnterpriseEn"] = "JianSuNanJingHongXinJiTuan";
            row["contractNumEn"] = "HTH29384848408504890";
            row["contractNum"] = "HTH29384848408504890";
            row["sellEnterpriseZh"] = "上海黄浦高科";
            row["sellEnterpriseEn"] = "ShangHaiHuangPuGaoKe";
            row["originArea"] = "江苏南京";
            row["originAreaEn"] = "JiangSuNanJing";
            row["packEn"] = "JingBao";
            row["pack"] = "精包";
            row["shipDate"] = "2010-7-1 10:55:50";
            row["shipArea"] = "南京路口机场";
            row["destination"] = "上海虹桥机场";
            row["tradeLanguage"] = "工厂交货";
            row["payment"] = "支票";
            row["contractDate"] = "2010-7-1 10:55:50";
            row["massRequrie"] = "GB/T23434345";
            row["buyer"] = "江苏南京红心集团";
            row["sheller"] = "上海黄浦高科";
            contract.Rows.Add(row);
            #endregion

            DataSet ds = new DataSet();
            ds.Tables.Add(contract);
            PrintThemp.EditTemplateDataSource odds = new PrintThemp.EditTemplateDataSource(ds);

            PrintThemp.EditTemplateInfo.EditDataSource = odds;











            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Application.Run(new PrintThemp.FrmEditMainPanel());
        }
    }
}
