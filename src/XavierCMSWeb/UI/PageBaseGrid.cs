﻿// GNU Version 3 License Copyright (c) 2020 Javier Cañon | https://javiercanon.com
//
// Permission is hereby granted, free of charge, to any person obtaining a copy
// of this software and associated documentation files (the "Software"), to
// deal in the Software without restriction, including without limitation the
// rights to use, copy, modify, merge, publish, distribute, sublicense, and/or
// sell copies of the Software, and to permit persons to whom the Software is
// furnished to do so, subject to the following conditions:
//
// The above copyright notice and this permission notice shall be included in
// all copies or substantial portions of the Software.
//
// THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
// IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
// FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
// AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
// LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING
// FROM, OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS
// IN THE SOFTWARE.
using System;
using System.Web.UI.WebControls;

namespace XavierCMSWeb.UI
{
    public abstract class PageBaseGrid : PageBaseCommon
    {

        public static string UniqueIdPageName, MasterTableName, MasterKeyFieldName, MasterGridCookieName, DetailGridCookieName;


        protected void Page_PreInit(object sender, EventArgs e)
        {

            //base.Page_PreInit( sender, e );
            
            UniqueIdPageName = Page.ToString().Replace(".", "_").ToLower();
            MasterGridCookieName = UniqueIdPageName + "_MasterGrid".ToLower();
            DetailGridCookieName = UniqueIdPageName + "_DetailGrid".ToLower();

            //MasterTableName = "ticket";
            //MasterKeyFieldName = "ID";

        }


        #region Datasources


        protected void DBMainDataSources_Selecting(object sender, SqlDataSourceSelectingEventArgs e)
        {
            e.Command.CommandTimeout = 60 * 5;
        }


        protected void DBMainDataSources_Init(object sender, EventArgs e)
        {
            var ds = (sender as SqlDataSource);
            ds.CacheKeyDependency = UniqueIdPageName + "_" + ds.UniqueID;
            ds.ConnectionString = Global.Configuration.DB.GetConnectionStringDBMain();

        }

        protected void DatasourcesCachesInit(string skey)
        {
            // CACHE
            if (Cache[skey] == null)
            {
                Cache[skey] = DateTime.Now;
            }
        }

        protected void DatasourcesCachesInvalidate(string skey)
        {
            // CACHE
            if (Cache[skey] != null)
            {
                Cache[skey] = DateTime.Now;
            }

        }


        #endregion Datasources

    }
}
