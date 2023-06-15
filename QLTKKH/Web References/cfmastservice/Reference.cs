﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

// 
// This source code was auto-generated by Microsoft.VSDesigner, Version 4.0.30319.42000.
// 
#pragma warning disable 1591

namespace QLTKKH.cfmastservice {
    using System.Diagnostics;
    using System;
    using System.Xml.Serialization;
    using System.ComponentModel;
    using System.Web.Services.Protocols;
    using System.Web.Services;
    
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.ComponentModel.DesignerCategoryAttribute("code")]
    [System.Web.Services.WebServiceBindingAttribute(Name="CFMASTWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class CFMASTWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback DuyetCFMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback SuaThemTienCIMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback SuaTruTienCIMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback ThemCFMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback SuaCFMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback XoaCFMASTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public CFMASTWebService() {
            this.Url = global::QLTKKH.Properties.Settings.Default.QLTKKH_cfmastservice_CFMASTWebService;
            if ((this.IsLocalFileSystemWebService(this.Url) == true)) {
                this.UseDefaultCredentials = true;
                this.useDefaultCredentialsSetExplicitly = false;
            }
            else {
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        public new string Url {
            get {
                return base.Url;
            }
            set {
                if ((((this.IsLocalFileSystemWebService(base.Url) == true) 
                            && (this.useDefaultCredentialsSetExplicitly == false)) 
                            && (this.IsLocalFileSystemWebService(value) == false))) {
                    base.UseDefaultCredentials = false;
                }
                base.Url = value;
            }
        }
        
        public new bool UseDefaultCredentials {
            get {
                return base.UseDefaultCredentials;
            }
            set {
                base.UseDefaultCredentials = value;
                this.useDefaultCredentialsSetExplicitly = true;
            }
        }
        
        /// <remarks/>
        public event DuyetCFMASTCompletedEventHandler DuyetCFMASTCompleted;
        
        /// <remarks/>
        public event SuaThemTienCIMASTCompletedEventHandler SuaThemTienCIMASTCompleted;
        
        /// <remarks/>
        public event SuaTruTienCIMASTCompletedEventHandler SuaTruTienCIMASTCompleted;
        
        /// <remarks/>
        public event ThemCFMASTCompletedEventHandler ThemCFMASTCompleted;
        
        /// <remarks/>
        public event SuaCFMASTCompletedEventHandler SuaCFMASTCompleted;
        
        /// <remarks/>
        public event XoaCFMASTCompletedEventHandler XoaCFMASTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/DuyetCFMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void DuyetCFMAST(string custid, string acctno, string martype, long mrcrlimitmax, string afacctno, long balance, long cidepofeeacr, long depofeeamt, System.DateTime lastchange) {
            this.Invoke("DuyetCFMAST", new object[] {
                        custid,
                        acctno,
                        martype,
                        mrcrlimitmax,
                        afacctno,
                        balance,
                        cidepofeeacr,
                        depofeeamt,
                        lastchange});
        }
        
        /// <remarks/>
        public void DuyetCFMASTAsync(string custid, string acctno, string martype, long mrcrlimitmax, string afacctno, long balance, long cidepofeeacr, long depofeeamt, System.DateTime lastchange) {
            this.DuyetCFMASTAsync(custid, acctno, martype, mrcrlimitmax, afacctno, balance, cidepofeeacr, depofeeamt, lastchange, null);
        }
        
        /// <remarks/>
        public void DuyetCFMASTAsync(string custid, string acctno, string martype, long mrcrlimitmax, string afacctno, long balance, long cidepofeeacr, long depofeeamt, System.DateTime lastchange, object userState) {
            if ((this.DuyetCFMASTOperationCompleted == null)) {
                this.DuyetCFMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnDuyetCFMASTOperationCompleted);
            }
            this.InvokeAsync("DuyetCFMAST", new object[] {
                        custid,
                        acctno,
                        martype,
                        mrcrlimitmax,
                        afacctno,
                        balance,
                        cidepofeeacr,
                        depofeeamt,
                        lastchange}, this.DuyetCFMASTOperationCompleted, userState);
        }
        
        private void OnDuyetCFMASTOperationCompleted(object arg) {
            if ((this.DuyetCFMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.DuyetCFMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SuaThemTienCIMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SuaThemTienCIMAST(string afacctno, string acctno, int money, System.DateTime lastchange) {
            this.Invoke("SuaThemTienCIMAST", new object[] {
                        afacctno,
                        acctno,
                        money,
                        lastchange});
        }
        
        /// <remarks/>
        public void SuaThemTienCIMASTAsync(string afacctno, string acctno, int money, System.DateTime lastchange) {
            this.SuaThemTienCIMASTAsync(afacctno, acctno, money, lastchange, null);
        }
        
        /// <remarks/>
        public void SuaThemTienCIMASTAsync(string afacctno, string acctno, int money, System.DateTime lastchange, object userState) {
            if ((this.SuaThemTienCIMASTOperationCompleted == null)) {
                this.SuaThemTienCIMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSuaThemTienCIMASTOperationCompleted);
            }
            this.InvokeAsync("SuaThemTienCIMAST", new object[] {
                        afacctno,
                        acctno,
                        money,
                        lastchange}, this.SuaThemTienCIMASTOperationCompleted, userState);
        }
        
        private void OnSuaThemTienCIMASTOperationCompleted(object arg) {
            if ((this.SuaThemTienCIMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SuaThemTienCIMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SuaTruTienCIMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SuaTruTienCIMAST(string afacctno, string acctno, int money, System.DateTime lastchange) {
            this.Invoke("SuaTruTienCIMAST", new object[] {
                        afacctno,
                        acctno,
                        money,
                        lastchange});
        }
        
        /// <remarks/>
        public void SuaTruTienCIMASTAsync(string afacctno, string acctno, int money, System.DateTime lastchange) {
            this.SuaTruTienCIMASTAsync(afacctno, acctno, money, lastchange, null);
        }
        
        /// <remarks/>
        public void SuaTruTienCIMASTAsync(string afacctno, string acctno, int money, System.DateTime lastchange, object userState) {
            if ((this.SuaTruTienCIMASTOperationCompleted == null)) {
                this.SuaTruTienCIMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSuaTruTienCIMASTOperationCompleted);
            }
            this.InvokeAsync("SuaTruTienCIMAST", new object[] {
                        afacctno,
                        acctno,
                        money,
                        lastchange}, this.SuaTruTienCIMASTOperationCompleted, userState);
        }
        
        private void OnSuaTruTienCIMASTOperationCompleted(object arg) {
            if ((this.SuaTruTienCIMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SuaTruTienCIMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ThemCFMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ThemCFMAST(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email) {
            this.Invoke("ThemCFMAST", new object[] {
                        custid,
                        fullname,
                        custodycd,
                        idtype,
                        idcode,
                        iddate,
                        address,
                        phone,
                        mobile,
                        email});
        }
        
        /// <remarks/>
        public void ThemCFMASTAsync(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email) {
            this.ThemCFMASTAsync(custid, fullname, custodycd, idtype, idcode, iddate, address, phone, mobile, email, null);
        }
        
        /// <remarks/>
        public void ThemCFMASTAsync(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email, object userState) {
            if ((this.ThemCFMASTOperationCompleted == null)) {
                this.ThemCFMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnThemCFMASTOperationCompleted);
            }
            this.InvokeAsync("ThemCFMAST", new object[] {
                        custid,
                        fullname,
                        custodycd,
                        idtype,
                        idcode,
                        iddate,
                        address,
                        phone,
                        mobile,
                        email}, this.ThemCFMASTOperationCompleted, userState);
        }
        
        private void OnThemCFMASTOperationCompleted(object arg) {
            if ((this.ThemCFMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ThemCFMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SuaCFMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SuaCFMAST(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email) {
            this.Invoke("SuaCFMAST", new object[] {
                        custid,
                        fullname,
                        custodycd,
                        idtype,
                        idcode,
                        iddate,
                        address,
                        phone,
                        mobile,
                        email});
        }
        
        /// <remarks/>
        public void SuaCFMASTAsync(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email) {
            this.SuaCFMASTAsync(custid, fullname, custodycd, idtype, idcode, iddate, address, phone, mobile, email, null);
        }
        
        /// <remarks/>
        public void SuaCFMASTAsync(string custid, string fullname, string custodycd, string idtype, string idcode, System.DateTime iddate, string address, string phone, string mobile, string email, object userState) {
            if ((this.SuaCFMASTOperationCompleted == null)) {
                this.SuaCFMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSuaCFMASTOperationCompleted);
            }
            this.InvokeAsync("SuaCFMAST", new object[] {
                        custid,
                        fullname,
                        custodycd,
                        idtype,
                        idcode,
                        iddate,
                        address,
                        phone,
                        mobile,
                        email}, this.SuaCFMASTOperationCompleted, userState);
        }
        
        private void OnSuaCFMASTOperationCompleted(object arg) {
            if ((this.SuaCFMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SuaCFMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/XoaCFMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void XoaCFMAST(string custid) {
            this.Invoke("XoaCFMAST", new object[] {
                        custid});
        }
        
        /// <remarks/>
        public void XoaCFMASTAsync(string custid) {
            this.XoaCFMASTAsync(custid, null);
        }
        
        /// <remarks/>
        public void XoaCFMASTAsync(string custid, object userState) {
            if ((this.XoaCFMASTOperationCompleted == null)) {
                this.XoaCFMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXoaCFMASTOperationCompleted);
            }
            this.InvokeAsync("XoaCFMAST", new object[] {
                        custid}, this.XoaCFMASTOperationCompleted, userState);
        }
        
        private void OnXoaCFMASTOperationCompleted(object arg) {
            if ((this.XoaCFMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.XoaCFMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        public new void CancelAsync(object userState) {
            base.CancelAsync(userState);
        }
        
        private bool IsLocalFileSystemWebService(string url) {
            if (((url == null) 
                        || (url == string.Empty))) {
                return false;
            }
            System.Uri wsUri = new System.Uri(url);
            if (((wsUri.Port >= 1024) 
                        && (string.Compare(wsUri.Host, "localHost", System.StringComparison.OrdinalIgnoreCase) == 0))) {
                return true;
            }
            return false;
        }
    }
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void DuyetCFMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SuaThemTienCIMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SuaTruTienCIMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void ThemCFMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SuaCFMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void XoaCFMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591