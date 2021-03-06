﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.Serialization;
using System.ServiceModel;
using System.Text;

using MEMS.DB.Models;
using MEMS.DB.ExtModels;

namespace MEMSservice
{
    // 注意: 使用“重构”菜单上的“重命名”命令，可以同时更改代码和配置文件中的接口名“ICRMService”。
    [ServiceContract]
    public interface ICRMService
    {
        [OperationContract]
        List<T_Customer> getCustomerList();
        [OperationContract]
        List<T_Customer> getCustomerListbyP(string cno, string cname, string csname);
        [OperationContract]
        T_Customer getCustomerbyid(int customerid);
        [OperationContract]
        void AddNewCustomer(T_Customer newcustomer);
        [OperationContract]
        void EditCustomer(T_Customer customer);
        [OperationContract]
        void DeleteCustomer(T_Customer customer);
        [OperationContract]
        List<T_Base_companytype> getCpytypeList();
        [OperationContract]
        List<T_Base_customertype> getCtmtypeList();
        [OperationContract]
        List<T_Base_profession> getProfList();
        [OperationContract]
        List<T_Customer_contacts> getCustomerContactList(int customerid);
        [OperationContract]
        List<T_Customer_address> getCustomerAddressList(int customerid);
        [OperationContract]
        void DelCustomerAddress(T_Customer_address address);
        [OperationContract]
        void DelCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        void AddCustomerAddress(T_Customer_address address);
        [OperationContract]
        void AddCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        void UpdCustomerAddress(T_Customer_address address);
        [OperationContract]
        void UpdCustomerContact(T_Customer_contacts contacts);
        [OperationContract]
        List<T_Suppliers> getAllSupplier();
        [OperationContract]
        List<T_Suppliers> getSupplierList(string spno, string spname);
        [OperationContract]
        T_Suppliers getSupplierbyId(int sid);
        [OperationContract]
        void addNewSupplier(T_Suppliers newsupplier);
        [OperationContract]
        void EditSupplier(T_Suppliers supplier);
        [OperationContract]
        void DeleteSupplier(T_Suppliers supplier);
        [OperationContract]
        List<T_Base_suppliertype> getSuptypeLst();
        [OperationContract]
        List<T_Suppliers_contacts> getSupplierContacts(int supplierid);
        [OperationContract]
        void AddSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        void EditSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        void DelSupplierContacts(T_Suppliers_contacts contact);
        [OperationContract]
        List<ProductList> getProductList();
        [OperationContract]
        List<T_Product> getProductListbyCid(int cid);
        [OperationContract]
        List<ProductList> getProductListbycdt(string pcode, string pname, int[] cid);
        [OperationContract]
        List<T_ProductType> getProductTypeList();
        [OperationContract]
        T_Product getProductbyId(int pid);
        [OperationContract]
        bool AddNewProduct(T_Product product);
        [OperationContract]
        bool UpdateProduct(T_Product product);
        [OperationContract]
        List<T_Crafts> getProductCraft(int pid);
        [OperationContract]
        bool AddNewCraft(T_Crafts craft);
        [OperationContract]
        bool UpdateCraft(T_Crafts craft);
        [OperationContract]
        bool DeleteCraft(T_Crafts craft);
        [OperationContract]
        List<T_ProductDraw> getProductDrawList(int productid);
        [OperationContract]
        List<T_ProductbasicPrice> getProductPriceList(int productid);
        [OperationContract]
        bool AddNewProductPrice(T_ProductbasicPrice price, List<T_CraftsPrice> newcplist);
        [OperationContract]
        List<T_CraftsPrice> getCraftPriceList(int productid);
        [OperationContract]
        string getPriceVersion(int pid);
        [OperationContract]
        List<T_quotation> getQuotationList();
        [OperationContract]
        List<T_quotation> getQuotationListbyP(string quno, int customerid, DateTime aftdate, DateTime bfedate);
        [OperationContract]
        T_quotation getQuotationbyId(int qid);
        [OperationContract]
        bool AddNewQuotation(T_quotation newqt);
        [OperationContract]
        bool AddNewQtAndQtprice(T_quotation newqt, List<QtProduct> qtpricelst);
        [OperationContract]
        bool UpdateQuotation(T_quotation qt);
        [OperationContract]
        bool DeleteQuotation(T_quotation qt);
        [OperationContract]
        List<QtProduct> getQtProduct(int Qtid);
        [OperationContract]
        bool AddNewQtPrice(QtProduct qtprice);
        [OperationContract]
        bool AddNewQtPriceList(List<QtProduct> qtpricelst);
    }
}
