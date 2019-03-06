using System;
using System.Collections.Generic;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace HwQueryMasterTest
{
    [TestClass]
    public class QueryMaster
    {
        [TestMethod]
        public void Get_Insert_Script_For_Product_Is_Ok()
        {
            var product = ProductManager.GetProduct();
            string query = QueryManager.GetInsert(product);
            Assert.AreNotEqual(String.Empty, query);
        }

        [TestMethod]
        public void Wrap_Insert_Scripts_Into_Text_File()
        {
            List<Product> products = ProductManager.GetProducts();
            var queries = QueryManager.GetInsertMany(products);
            bool result = WrapManager.WrapToText(queries.ToString());
            Assert.AreEqual(true, result);
        }

        [TestMethod]
        public void Wrap_Insert_Scripts_Into_Json_File()
        {
            List<Product> products = ProductManager.GetProducts();
            var queries = QueryManager.GetInsertMany(products);
            string fileContext = WrapManager.WrapToJson(queries);
            Assert.AreNotEqual(0, fileContext.Length);
        }

        [TestMethod]
        public void Wrap_Insert_Scripts_Into_Xml_File()
        {
            List<Product> products = ProductManager.GetProducts();
            var queries = QueryManager.GetInsertMany(products);
            string fileContext = WrapManager.WrapToXml(queries);
            Assert.AreNotEqual(0, fileContext.Length);
        }

        [TestMethod]
        public void Wrap_Insert_Scripts_Into_Db()
        {
            List<Product> products = ProductManager.GetProducts();
            var queries = QueryManager.GetInsertMany(products);
            string fileContext = WrapManager.WrapToDb(queries);
            Assert.AreNotEqual(0, fileContext.Length);
        }

        [TestMethod]
        public void Wrap_Insert_Scripts()
        {
            List<Product> products = ProductManager.GetProducts();
            var queries = QueryManager.GetInsertMany(products);
            IStrategy strategy = new DbConvertStrategy();
            string fileContext = WrapManager.Wrap(strategy);
            Assert.AreNotEqual(0, fileContext.Length);
        }
    }

}
