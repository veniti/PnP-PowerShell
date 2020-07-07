using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using System.Management.Automation.Runspaces;

namespace SharePointPnP.PowerShell.Tests.Lists
{
    [TestClass]
    public class RemoveListItemTests
    {
        #region Test Setup/CleanUp
        [ClassInitialize]
        public static void Initialize(TestContext testContext)
        {
            // This runs on class level once before all tests run
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [ClassCleanup]
        public static void Cleanup(TestContext testContext)
        {
            // This runs on class level once
            //using (var ctx = TestCommon.CreateClientContext())
            //{
            //}
        }

        [TestInitialize]
        public void Initialize()
        {
            using (var scope = new PSTestScope())
            {
                // Example
                // scope.ExecuteCommand("cmdlet", new CommandParameter("param1", prop));
            }
        }

        [TestCleanup]
        public void Cleanup()
        {
            using (var scope = new PSTestScope())
            {
                try
                {
                    // Do Test Setup - Note, this runs PER test
                }
                catch (Exception)
                {
                    // Describe Exception
                }
            }
        }
        #endregion

        #region Scaffolded Cmdlet Tests
        //TODO: This is a scaffold of the cmdlet - complete the unit test
        //[TestMethod]
        public void RemovePnPListItemTest()
        {
            using (var scope = new PSTestScope(true))
            {
                // Complete writing cmd parameters

				// This is a mandatory parameter
				// From Cmdlet Help: The ID, Title or Url of the list.
				var list = "";
				// This is a mandatory parameter
				// From Cmdlet Help: The ID of the listitem, or actual ListItem object
				var identity = "";
				var recycle = "";
				// From Cmdlet Help: Specifying the Force parameter will skip the confirmation question.
				var force = "";

                var results = scope.ExecuteCommand("Remove-PnPListItem",
					new CommandParameter("List", list),
					new CommandParameter("Identity", identity),
					new CommandParameter("Recycle", recycle),
					new CommandParameter("Force", force));
                
                Assert.IsNotNull(results);
            }
        }
        #endregion
    }
}
            