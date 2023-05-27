﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MyApp_HiepBui
{
    using System;
    using System.Data.Entity;
    using System.Data.Entity.Infrastructure;
    using System.Data.Entity.Core.Objects;
    using System.Linq;
    
    public partial class ConvenienceStoreManagementEntities : DbContext
    {
        public ConvenienceStoreManagementEntities()
            : base("name=ConvenienceStoreManagementEntities")
        {
        }
    
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            throw new UnintentionalCodeFirstException();
        }
    
        public virtual DbSet<ACCOUNT> ACCOUNTs { get; set; }
        public virtual DbSet<AUTHORITY> AUTHORITies { get; set; }
        public virtual DbSet<CUSTOMER> CUSTOMERS { get; set; }
        public virtual DbSet<EMPLOYEE> EMPLOYEES { get; set; }
        public virtual DbSet<GROUP_OF_EMPLOYEE> GROUP_OF_EMPLOYEE { get; set; }
        public virtual DbSet<ITEM_IN_ORDER> ITEM_IN_ORDER { get; set; }
        public virtual DbSet<ITEM> ITEMS { get; set; }
        public virtual DbSet<KIND_OF_EMPLOYEE> KIND_OF_EMPLOYEE { get; set; }
        public virtual DbSet<ORDER> ORDERS { get; set; }
        public virtual DbSet<PAYMENT_TYPE> PAYMENT_TYPE { get; set; }
        public virtual DbSet<STORE> STOREs { get; set; }
        public virtual DbSet<SUPPLIER> SUPPLIERs { get; set; }
        public virtual DbSet<sysdiagram> sysdiagrams { get; set; }
        public virtual DbSet<TYPE_OF_CUSTOMER> TYPE_OF_CUSTOMER { get; set; }
        public virtual DbSet<TYPE_OF_ITEM> TYPE_OF_ITEM { get; set; }
        public virtual DbSet<TYPE_OF_USER> TYPE_OF_USER { get; set; }
        public virtual DbSet<WAREHOUSE> WAREHOUSEs { get; set; }
        public virtual DbSet<WORKINGTIME> WORKINGTIMEs { get; set; }
        public virtual DbSet<Employees_View> Employees_Views { get; set; }
        public virtual DbSet<Gold_Customer> Gold_Customers { get; set; }
        public virtual DbSet<Platinum_Customer> Platinum_Customers { get; set; }
        public virtual DbSet<Salary_Of_Employee> Salary_Of_Employee { get; set; }
        public virtual DbSet<Silver_Customer> Silver_Customers { get; set; }
        public virtual DbSet<v_Account_Authority> v_Account_Authority { get; set; }
        public virtual DbSet<v_Info_Of_Customers> v_Info_Of_Customers { get; set; }
        public virtual DbSet<v_Info_Of_Employee> v_Info_Of_Employee { get; set; }
        public virtual DbSet<v_Order_Detail> v_Order_Detail { get; set; }
        public virtual DbSet<v_Order_Detail_new_> v_Order_Detail_new_ { get; set; }
        public virtual DbSet<v_Order_Detail_For_Export> v_Order_Detail_For_Export { get; set; }
        public virtual DbSet<v_Status_Of_WareHouse> v_Status_Of_WareHouse { get; set; }
        public virtual DbSet<v_Working_time> v_Working_time { get; set; }
        public virtual DbSet<View_Item> View_Items { get; set; }
    
        [DbFunction("ConvenienceStoreManagementEntities", "SearchOrderByName")]
        public virtual IQueryable<SearchOrderByName_Result> SearchOrderByName(string name)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchOrderByName_Result>("[ConvenienceStoreManagementEntities].[SearchOrderByName](@Name)", nameParameter);
        }
    
        [DbFunction("ConvenienceStoreManagementEntities", "SearchOrderByPhone")]
        public virtual IQueryable<SearchOrderByPhone_Result> SearchOrderByPhone(string phone)
        {
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.CreateQuery<SearchOrderByPhone_Result>("[ConvenienceStoreManagementEntities].[SearchOrderByPhone](@Phone)", phoneParameter);
        }
    
        public virtual int Add_Account(string ide, string username, string password)
        {
            var ideParameter = ide != null ?
                new ObjectParameter("ide", ide) :
                new ObjectParameter("ide", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Account", ideParameter, usernameParameter, passwordParameter);
        }
    
        public virtual int Add_Employee(string name, Nullable<System.DateTime> dateofbirth, string address, string phone, Nullable<bool> status_emp, string idkindemp, string idgroup, string idtypeuser, string idstore)
        {
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var dateofbirthParameter = dateofbirth.HasValue ?
                new ObjectParameter("dateofbirth", dateofbirth) :
                new ObjectParameter("dateofbirth", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var status_empParameter = status_emp.HasValue ?
                new ObjectParameter("status_emp", status_emp) :
                new ObjectParameter("status_emp", typeof(bool));
    
            var idkindempParameter = idkindemp != null ?
                new ObjectParameter("idkindemp", idkindemp) :
                new ObjectParameter("idkindemp", typeof(string));
    
            var idgroupParameter = idgroup != null ?
                new ObjectParameter("idgroup", idgroup) :
                new ObjectParameter("idgroup", typeof(string));
    
            var idtypeuserParameter = idtypeuser != null ?
                new ObjectParameter("idtypeuser", idtypeuser) :
                new ObjectParameter("idtypeuser", typeof(string));
    
            var idstoreParameter = idstore != null ?
                new ObjectParameter("idstore", idstore) :
                new ObjectParameter("idstore", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_Employee", nameParameter, dateofbirthParameter, addressParameter, phoneParameter, status_empParameter, idkindempParameter, idgroupParameter, idtypeuserParameter, idstoreParameter);
        }
    
        public virtual int Add_WorkingTime(string ide, Nullable<int> totaltime)
        {
            var ideParameter = ide != null ?
                new ObjectParameter("ide", ide) :
                new ObjectParameter("ide", typeof(string));
    
            var totaltimeParameter = totaltime.HasValue ?
                new ObjectParameter("totaltime", totaltime) :
                new ObjectParameter("totaltime", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Add_WorkingTime", ideParameter, totaltimeParameter);
        }
    
        public virtual int AddNewItem(string name, Nullable<int> price, Nullable<System.DateTime> mFGDate, string type, string supplier, Nullable<int> quantity)
        {
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var mFGDateParameter = mFGDate.HasValue ?
                new ObjectParameter("MFGDate", mFGDate) :
                new ObjectParameter("MFGDate", typeof(System.DateTime));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var supplierParameter = supplier != null ?
                new ObjectParameter("Supplier", supplier) :
                new ObjectParameter("Supplier", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("Quantity", quantity) :
                new ObjectParameter("Quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewItem", nameParameter, priceParameter, mFGDateParameter, typeParameter, supplierParameter, quantityParameter);
        }
    
        public virtual int AddNewOrder(string iDOrder, string phone, string iDItem, Nullable<int> quantity)
        {
            var iDOrderParameter = iDOrder != null ?
                new ObjectParameter("IDOrder", iDOrder) :
                new ObjectParameter("IDOrder", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var iDItemParameter = iDItem != null ?
                new ObjectParameter("IDItem", iDItem) :
                new ObjectParameter("IDItem", typeof(string));
    
            var quantityParameter = quantity.HasValue ?
                new ObjectParameter("quantity", quantity) :
                new ObjectParameter("quantity", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("AddNewOrder", iDOrderParameter, phoneParameter, iDItemParameter, quantityParameter);
        }
    
        public virtual ObjectResult<Assign_Employee_Permission_Result> Assign_Employee_Permission(string idemp, string id_authority, ObjectParameter err)
        {
            var idempParameter = idemp != null ?
                new ObjectParameter("idemp", idemp) :
                new ObjectParameter("idemp", typeof(string));
    
            var id_authorityParameter = id_authority != null ?
                new ObjectParameter("id_authority", id_authority) :
                new ObjectParameter("id_authority", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Assign_Employee_Permission_Result>("Assign_Employee_Permission", idempParameter, id_authorityParameter, err);
        }
    
        public virtual int CreateNewOrder(string newIDOrder, string phone)
        {
            var newIDOrderParameter = newIDOrder != null ?
                new ObjectParameter("NewIDOrder", newIDOrder) :
                new ObjectParameter("NewIDOrder", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("CreateNewOrder", newIDOrderParameter, phoneParameter);
        }
    
        public virtual int Edit_Account(string ide, string username, string password)
        {
            var ideParameter = ide != null ?
                new ObjectParameter("ide", ide) :
                new ObjectParameter("ide", typeof(string));
    
            var usernameParameter = username != null ?
                new ObjectParameter("username", username) :
                new ObjectParameter("username", typeof(string));
    
            var passwordParameter = password != null ?
                new ObjectParameter("password", password) :
                new ObjectParameter("password", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Edit_Account", ideParameter, usernameParameter, passwordParameter);
        }
    
        public virtual int Edit_Employee(string ide, string name, Nullable<System.DateTime> dateofbirth, string address, string phone, Nullable<bool> status_emp, string id_kind_emp, string id_group, string id_type_user, string id_store)
        {
            var ideParameter = ide != null ?
                new ObjectParameter("ide", ide) :
                new ObjectParameter("ide", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("name", name) :
                new ObjectParameter("name", typeof(string));
    
            var dateofbirthParameter = dateofbirth.HasValue ?
                new ObjectParameter("dateofbirth", dateofbirth) :
                new ObjectParameter("dateofbirth", typeof(System.DateTime));
    
            var addressParameter = address != null ?
                new ObjectParameter("address", address) :
                new ObjectParameter("address", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("phone", phone) :
                new ObjectParameter("phone", typeof(string));
    
            var status_empParameter = status_emp.HasValue ?
                new ObjectParameter("status_emp", status_emp) :
                new ObjectParameter("status_emp", typeof(bool));
    
            var id_kind_empParameter = id_kind_emp != null ?
                new ObjectParameter("id_kind_emp", id_kind_emp) :
                new ObjectParameter("id_kind_emp", typeof(string));
    
            var id_groupParameter = id_group != null ?
                new ObjectParameter("id_group", id_group) :
                new ObjectParameter("id_group", typeof(string));
    
            var id_type_userParameter = id_type_user != null ?
                new ObjectParameter("id_type_user", id_type_user) :
                new ObjectParameter("id_type_user", typeof(string));
    
            var id_storeParameter = id_store != null ?
                new ObjectParameter("id_store", id_store) :
                new ObjectParameter("id_store", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Edit_Employee", ideParameter, nameParameter, dateofbirthParameter, addressParameter, phoneParameter, status_empParameter, id_kind_empParameter, id_groupParameter, id_type_userParameter, id_storeParameter);
        }
    
        public virtual int Edit_WorkingTime(string ide, Nullable<int> totaltime)
        {
            var ideParameter = ide != null ?
                new ObjectParameter("ide", ide) :
                new ObjectParameter("ide", typeof(string));
    
            var totaltimeParameter = totaltime.HasValue ?
                new ObjectParameter("totaltime", totaltime) :
                new ObjectParameter("totaltime", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("Edit_WorkingTime", ideParameter, totaltimeParameter);
        }
    
        public virtual int employee_authority(string id_employee, string id_typeuser)
        {
            var id_employeeParameter = id_employee != null ?
                new ObjectParameter("id_employee", id_employee) :
                new ObjectParameter("id_employee", typeof(string));
    
            var id_typeuserParameter = id_typeuser != null ?
                new ObjectParameter("id_typeuser", id_typeuser) :
                new ObjectParameter("id_typeuser", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("employee_authority", id_employeeParameter, id_typeuserParameter);
        }
    
        public virtual int ModifyItem(string iDItem, string name, Nullable<int> price, string type, string supplier)
        {
            var iDItemParameter = iDItem != null ?
                new ObjectParameter("IDItem", iDItem) :
                new ObjectParameter("IDItem", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var priceParameter = price.HasValue ?
                new ObjectParameter("Price", price) :
                new ObjectParameter("Price", typeof(int));
    
            var typeParameter = type != null ?
                new ObjectParameter("Type", type) :
                new ObjectParameter("Type", typeof(string));
    
            var supplierParameter = supplier != null ?
                new ObjectParameter("Supplier", supplier) :
                new ObjectParameter("Supplier", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("ModifyItem", iDItemParameter, nameParameter, priceParameter, typeParameter, supplierParameter);
        }
    
        public virtual int sp_alterdiagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_alterdiagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_creatediagram(string diagramname, Nullable<int> owner_id, Nullable<int> version, byte[] definition)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var versionParameter = version.HasValue ?
                new ObjectParameter("version", version) :
                new ObjectParameter("version", typeof(int));
    
            var definitionParameter = definition != null ?
                new ObjectParameter("definition", definition) :
                new ObjectParameter("definition", typeof(byte[]));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_creatediagram", diagramnameParameter, owner_idParameter, versionParameter, definitionParameter);
        }
    
        public virtual int sp_dropdiagram(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_dropdiagram", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagramdefinition_Result> sp_helpdiagramdefinition(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagramdefinition_Result>("sp_helpdiagramdefinition", diagramnameParameter, owner_idParameter);
        }
    
        public virtual ObjectResult<sp_helpdiagrams_Result> sp_helpdiagrams(string diagramname, Nullable<int> owner_id)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<sp_helpdiagrams_Result>("sp_helpdiagrams", diagramnameParameter, owner_idParameter);
        }
    
        public virtual int sp_renamediagram(string diagramname, Nullable<int> owner_id, string new_diagramname)
        {
            var diagramnameParameter = diagramname != null ?
                new ObjectParameter("diagramname", diagramname) :
                new ObjectParameter("diagramname", typeof(string));
    
            var owner_idParameter = owner_id.HasValue ?
                new ObjectParameter("owner_id", owner_id) :
                new ObjectParameter("owner_id", typeof(int));
    
            var new_diagramnameParameter = new_diagramname != null ?
                new ObjectParameter("new_diagramname", new_diagramname) :
                new ObjectParameter("new_diagramname", typeof(string));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_renamediagram", diagramnameParameter, owner_idParameter, new_diagramnameParameter);
        }
    
        public virtual int sp_upgraddiagrams()
        {
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("sp_upgraddiagrams");
        }
    
        public virtual int USP_AddCustomer(string idCustomer, string name, string phone, Nullable<System.DateTime> openingDate, Nullable<System.DateTime> transactionDate, Nullable<int> accumulatedPoint)
        {
            var idCustomerParameter = idCustomer != null ?
                new ObjectParameter("IdCustomer", idCustomer) :
                new ObjectParameter("IdCustomer", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var openingDateParameter = openingDate.HasValue ?
                new ObjectParameter("OpeningDate", openingDate) :
                new ObjectParameter("OpeningDate", typeof(System.DateTime));
    
            var transactionDateParameter = transactionDate.HasValue ?
                new ObjectParameter("TransactionDate", transactionDate) :
                new ObjectParameter("TransactionDate", typeof(System.DateTime));
    
            var accumulatedPointParameter = accumulatedPoint.HasValue ?
                new ObjectParameter("AccumulatedPoint", accumulatedPoint) :
                new ObjectParameter("AccumulatedPoint", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_AddCustomer", idCustomerParameter, nameParameter, phoneParameter, openingDateParameter, transactionDateParameter, accumulatedPointParameter);
        }
    
        public virtual ObjectResult<Nullable<int>> USP_AnalyseCustomer(Nullable<int> month_of_OpeningDate)
        {
            var month_of_OpeningDateParameter = month_of_OpeningDate.HasValue ?
                new ObjectParameter("Month_of_OpeningDate", month_of_OpeningDate) :
                new ObjectParameter("Month_of_OpeningDate", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction<Nullable<int>>("USP_AnalyseCustomer", month_of_OpeningDateParameter);
        }
    
        public virtual int USP_Update_InfoCustomer(string idCustomer, string name, string phone, Nullable<System.DateTime> openingDate, Nullable<System.DateTime> transactionDate, Nullable<int> accumulatedPoint)
        {
            var idCustomerParameter = idCustomer != null ?
                new ObjectParameter("IdCustomer", idCustomer) :
                new ObjectParameter("IdCustomer", typeof(string));
    
            var nameParameter = name != null ?
                new ObjectParameter("Name", name) :
                new ObjectParameter("Name", typeof(string));
    
            var phoneParameter = phone != null ?
                new ObjectParameter("Phone", phone) :
                new ObjectParameter("Phone", typeof(string));
    
            var openingDateParameter = openingDate.HasValue ?
                new ObjectParameter("OpeningDate", openingDate) :
                new ObjectParameter("OpeningDate", typeof(System.DateTime));
    
            var transactionDateParameter = transactionDate.HasValue ?
                new ObjectParameter("TransactionDate", transactionDate) :
                new ObjectParameter("TransactionDate", typeof(System.DateTime));
    
            var accumulatedPointParameter = accumulatedPoint.HasValue ?
                new ObjectParameter("AccumulatedPoint", accumulatedPoint) :
                new ObjectParameter("AccumulatedPoint", typeof(int));
    
            return ((IObjectContextAdapter)this).ObjectContext.ExecuteFunction("USP_Update_InfoCustomer", idCustomerParameter, nameParameter, phoneParameter, openingDateParameter, transactionDateParameter, accumulatedPointParameter);
        }
    }
}