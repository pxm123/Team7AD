using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibraryBL.EntityFacade;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using ClassLibraryBL.Entities;
using ClassLibraryBL;
namespace UnitTestFacade
{
    [TestClass]
    public class UnitTestFacade
    {
        //For testing ViewPendingFormFacade to check whether the value has been passed from front to facade and go back correctly
        ViewPendingFormFacade vpfFacade = new ViewPendingFormFacade();


        [TestMethod]
        public void ViewPendingFormFacade()
        {
            Object o = vpfFacade.getAllPendingItems();
            Assert.IsNotNull(o);

        }


        [TestMethod]
        public void getListByDept()
        {
            String selectedValue = "English Dept";
            Object o = vpfFacade.getListByDept(selectedValue);
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getListByDeptDetail()
        {
            int i = 107;
            Object o = vpfFacade.getListByDeptDetail(i.ToString());
            Assert.IsNotNull(o);

        }


        //For testing UserFacade to check whether the value has been passed from front to facade and go back correctly
        UserFacade userFacade = new UserFacade();

        [TestMethod]
        public void delegateAuthority()
        {
            String uid = "u002";
            userFacade.delegateAuthority(uid);
        }

        [TestMethod]
        public void AssignNewRep()
        {
            String uid = "u002";
            userFacade.AssignNewRep(uid);
        }


        //For testing TrendForSupplierFacade to check whether the value has been passed from front to facade and go back correctly
        TrendForSupplierFacade tfsFacade = new TrendForSupplierFacade();

        [TestMethod]
        public void GetPrice()
        {
            string department="English Dept";
            string category="Notebook";
            int month = 10;
            Object o= tfsFacade.GetPrice(department, category, month);
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getUnit()
        {
            string category = "Notebook";
            tfsFacade.getUnit(category);
        }

        //For testing SupplierFacade to check whether the value has been passed from front to facade and go back correctly

        SupplierFacade supplierFacade = new SupplierFacade();
        [TestMethod]
        public void checksupplierList()
        {
             List<supplier> l= supplierFacade.checksupplierList();
             Assert.IsNotNull(l);

        }
        [TestMethod]
        public void deletesupplier()
        {
            supplierFacade.deletesupplier(2070);
            // exception in this stage
        }

        public void searchbydescription()
        {
            supplierFacade.searchbydescription("Notebook", 2070);
        }

        [TestMethod]
        public void showitems()
        {
            List<SupplieritemMix> l = supplierFacade.showitems(2070);
            Assert.IsNotNull(l);
        }
        
        [TestMethod]
        public void editprice()
        {
            supplierFacade.editprice(1, 2070, 80);
        }

        [TestMethod]
        public void findSupplier()
        {
           supplier s=  supplierFacade.findsupplier(2084);
           Assert.IsNotNull(s);
        }

         [TestMethod]
        public void showsingleitem()
        {
            SupplieritemMix sm = supplierFacade.showsingleitem(1, 2000);
            Assert.IsNotNull(sm);
        }


        //For testing RequisitionTrendFacade to check whether the value has been passed from front to facade and go back correctly
         RequisitionTrendFacade rtFacede = new RequisitionTrendFacade();
         [TestMethod]
         public void GetCategoryName()
         {
            List<string> l= rtFacede.GetCategoryName();
            Assert.IsNotNull(l);
         }

         //For testing RequisitionFacade to check whether the value has been passed from front to facade and go back correctly
         RequisiitonFacade rFacade = new RequisiitonFacade();
         [TestMethod]
         public void getRequisitionDetails()
         {
            String rid = "60";
            List<RequisitionDetails> l=  rFacade.getRequisitionDetails(rid);
            Assert.IsNotNull(l);
         }

          [TestMethod]
         public void approveRequisition()
         {
             rFacade.approveRequisition(1130);
         }

         [TestMethod]
         public void rejectRequisition()
          {
              rFacade.rejectRequisition(1130, "Testing");
          }

        [TestMethod]
         public void checkItemAvailable()
         {
             rFacade.checkItemAvailable(1130);
         }

         [TestMethod]
        public void getRequisition()
        {
            Object o= rFacade.getRequisition();
        }

        [TestMethod]
         public void getRequisition2()
         {
             List<requisitionEntity> l = rFacade.getRequisition2();
             Assert.IsNotNull(l);
         }

        [TestMethod]
        public void getPendingRequisition()
        {
            List<requisitionEntity> l = rFacade.getPendingRequisition();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void getWaitingRequisition()
        {
            List<requisitionEntity> l = rFacade.getWaitingRequisition();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void getCompletedRequisition()
        {
            List<requisitionEntity> l = rFacade.getCompletedRequisition();
            Assert.IsNotNull(l);
        }

       [TestMethod]
        public void currentweekbyitem()
        {
            List<RequisitionMix> l = rFacade.currentweekbyitem();
            Assert.IsNotNull(l);
        }

        [TestMethod]
       public void currentweekbydepartment(string s)
       {
           List<RequisitionMix> l = rFacade.currentweekbydepartment("Commerce");
           Assert.IsNotNull(l);
       }
        [TestMethod]
        public void itemwithoutdate()
        {
            List<RequisitionMix> l = rFacade.itemwithoutdate();
            Assert.IsNotNull(l);
        }
        [TestMethod]
        public void itemwithdate()
        {
            List<RequisitionMix> l = rFacade.itemwithdate("01/01/2015", "02/02/2015");
            Assert.IsNotNull(l);
        }
        [TestMethod]
        public void departmentwithoutdate()
        {
            List<RequisitionMix> l = rFacade.departmentwithoutdate("COMM");
            Assert.IsNotNull(l);
        }
        [TestMethod]
        public void departmentwithdate()
        {
            List<RequisitionMix> l = rFacade.departmentwithdate("COMM", "01/01/2015", "02/02/2015");
        }

        //For testing RequestThreeMonthsEntityFacade to check whether the value has been passed from front to facade and go back correctly
        RequestThreeMonthsEntityFacade rtmFacade = new RequestThreeMonthsEntityFacade();

        [TestMethod]
        public void GetRequestThreeMonthsEntity()
        {
            List<RequestThreeMonthsEntity> l = rtmFacade.GetRequestThreeMonthsEntity(11, "Commerce");
        }

        //For testing RequestItemFacade to check whether the value has been passed from front to facade and go back correctly
        RequestItemFacade riFacade = new RequestItemFacade();

        [TestMethod]
         public void GetCategoryName1()
        {
            List<RequestItem> l = riFacade.GetCategoryName();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void GetCategorSum()
        {
            int i = riFacade.GetCategorSum("Eraser");
            Assert.IsNotNull(i);
        }

        //For testing ReportOrderFacade to check whether the value has been passed from front to facade and go back correctly
        ReportOrderFacade roFacade = new ReportOrderFacade();

        [TestMethod]
        public void GetRequestQty(string categoryName, int month)
        {
            List<ReportOrderEntity> l = roFacade.GetRequestQty("Eraser", 8);
            Assert.IsNotNull(l);
        }

        //For testing PurchaseOrderFacade to check whether the value has been passed from front to facade and go back correctly
        PurchaseOrderFacade poFacade = new PurchaseOrderFacade();

        [TestMethod]
        public void findpurchaseorder()
        {
            purchase p = poFacade.findpurchaseorder(1);
            Assert.IsNotNull(p);
        }

        [TestMethod]
        public void confirmorder()
        {
            poFacade.confirmorder(1);
        }

        [TestMethod]
        public void additems()
        {
            poFacade.additems(1, 2000, 1, 1);
        }

        [TestMethod]
        public void showitemsbysupplier()
        {
            List<string> l = poFacade.showitemsbysupplier(1);
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void finditemcode()
        {
            int i = poFacade.finditemcode("testing", 1);
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void newpurchase()
        {
            purchase p = poFacade.newpurchase(1, "u005");
        }

        [TestMethod]
        public void findsupplier()
        {
            int i = poFacade.findsupplier(17);
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void getPurchaseOrder()
        {
            List<purchaseEntity> l = poFacade.getPurchaseOrder();
            Assert.IsNotNull(l);
        }

        //For testing LoginFacade to check whether the value has been passed from front to facade and go back correctly
        loginFacade loFacade = new loginFacade();

        [TestMethod]
         public void loginvalidate()
        {
            bool b = loFacade.loginvalidate("dudu@hotmail.com", "ibm11ibm");
            Assert.AreEqual(b, true);
        }

        [TestMethod]
        public void getuserinfo()
        {
            user u = loFacade.getuserinfo("dudu@hotmail.com", "ibm11ibm");
            Assert.IsNotNull(u);
        }

        [TestMethod]
        public void fillInEntity()
        {
            User u = loFacade.fillInEntity("dudu@hotmail.com", "ibm11ibm");
            Assert.IsNotNull(u);
        }

        //For testing InventoryFacade to check whether the value has been passed from front to facade and go back correctly
        InventoryFacade inFacade = new InventoryFacade();

        [TestMethod]
        public void getInventoryData()
        {
            Object o = inFacade.getInventoryData();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getLowBalanceData()
        {
            Object o = inFacade.getLowBalanceData();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getItemById()
        {
            itemEntity i = inFacade.getItemById(6);
            Assert.IsNotNull(i);
        }

        [TestMethod]
        public void getItemByName()
        {
            List<itemEntity> l = inFacade.getItemByName("Fancy Notebook");
            Assert.IsNotNull(l);
        }

        //For testing DiscrepancyFacade to check whether the value has been passed from front to facade and go back correctly
        DiscrepancyFacade disFacade = new DiscrepancyFacade();
        [TestMethod]
        public void getCategory()
        {
            Object o = disFacade.getCategory();
            Assert.IsNotNull(o);
        }
        [TestMethod]
        public void getCategoryItem()
        {
            Object o = disFacade.getCategoryItem("Eraser");
        }

        [TestMethod]
        public void getUnitInDiscrepancy()
        {
            String i = disFacade.getCategoryItem("Eraser").ToString();
            Assert.AreEqual("pec", i);
            
        }

        [TestMethod]
        public void ListHistory()
        {
            Object o = disFacade.ListHistory();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getDiscrepanyDetail()
        {
            Object o = disFacade.getDiscrepanyDetail("3");
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getpendingdiscrepancy()
        {
            List<DiscrepancyMixBean> l = disFacade.getpendingdiscrepancy();
            Assert.IsNotNull(l);
        }
        [TestMethod]
        public void getdiscrepancyitem()
        {
            List<DiscrepancyItemMix> l = disFacade.getdiscrepancyitem(3);
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void approvediscrepancy()
        {
            disFacade.approvediscrepancy(3);
        }

        [TestMethod]
        public void rejectdiscrepancy()
        {
            disFacade.rejectdiscrepancy(3);
        }

        [TestMethod]
        public void ListHistory2()
        {
            List<discrepancyEntity> l = disFacade.ListHistory2();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void getDiscrepanyDetail2()
        {
            List<discrepancyDetailEntityMobile> l = disFacade.getDiscrepanyDetail2("3");
            Assert.IsNotNull(l);
        }

        //For testing DisbursementFacade to check whether the value has been passed from front to facade and go back correctly
        DisbursementFacade disburseFacade = new DisbursementFacade();

        [TestMethod]
        public void getCurrentList()
        {
            Object o= disburseFacade.getCurrentList("Commerce");
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getDetailedItem()
        {
            Object o = disburseFacade.getDetailedItem(2);
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getCollectionPoint()
        {
            Object o = disburseFacade.getCollectionPoint("Commerce");
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getAllHistoryList()
        {
            Object o = disburseFacade.getAllHistoryList();
            Assert.IsNotNull(o);
        }

        [TestMethod]
        public void getHistoryListDetails()
        {
            Object o = disburseFacade.getHistoryListDetails("10");
            Assert.IsNotNull(o);
        }
        
        [TestMethod]
        public void getCurrentList2()
        {
            List<RequisitionMix> l = disburseFacade.getCurrentList2("Commerce");
            Assert.IsNotNull(l);
        }

        //For testing Department to check whether the value has been passed from front to facade and go back correctly
        DepartmentFacade departmentFacade = new DepartmentFacade();

        [TestMethod]
        public void GetDepName()
        {
            List<Department> l = departmentFacade.GetDepName();
            Assert.IsNotNull(l);
        }

        [TestMethod]
        public void GetDepName2()
        {
            List<department> l = departmentFacade.GetDepName2();
            Assert.IsNotNull(l);
        }


    }
}
