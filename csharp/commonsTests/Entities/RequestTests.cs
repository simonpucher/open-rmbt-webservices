using Microsoft.VisualStudio.TestTools.UnitTesting;
using commons;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace commons.Tests
{
    [TestClass()]
    public class RequestTests
    {
        [TestMethod()]
        public void GET_OneTestTest()
        {
            try
            {
                Request req = new Request();
                TestResponse resp = req.GET_OneTest("O211ec703-71db-4c32-b61a-77fc1bbf1705", "m7n8o9p10q11") as TestResponse;

                Assert.IsNotNull(resp);
                Assert.IsNotNull(resp.asn);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
            
        }

        [TestMethod()]
        public void GET_QosTest()
        {
            try
            {
                Request req = new Request();
                QosResponse resp = req.GET_Qos("O56b5cc79-5669-4457-bce2-0aeaf3b7242f") as QosResponse;

                Assert.IsNotNull(resp);
                Assert.IsTrue(resp.testresultdetail.Count > 0);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }

        [TestMethod()]
        public void GET_SearchTest()
        {
            try
            {
                Request req = new Request();
                SearchResponse resp = req.GET_Search(1764, "a1b2c3d4e5f6") as SearchResponse;

                Assert.IsNotNull(resp); 
                Assert.IsNotNull(resp.duration_ms);
            }
            catch (Exception ex)
            {
                Assert.Fail(ex.Message);
            }
        }
    }
}