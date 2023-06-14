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

namespace QLTKKH.semastservice {
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
    [System.Web.Services.WebServiceBindingAttribute(Name="_SEMASTWebServiceSoap", Namespace="http://tempuri.org/")]
    public partial class _SEMASTWebService : System.Web.Services.Protocols.SoapHttpClientProtocol {
        
        private System.Threading.SendOrPostCallback ThemSEMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback SuaSEMASTOperationCompleted;
        
        private System.Threading.SendOrPostCallback XoaCFMASTOperationCompleted;
        
        private bool useDefaultCredentialsSetExplicitly;
        
        /// <remarks/>
        public _SEMASTWebService() {
            this.Url = global::QLTKKH.Properties.Settings.Default.QLTKKH_semastservice__SEMASTWebService;
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
        public event ThemSEMASTCompletedEventHandler ThemSEMASTCompleted;
        
        /// <remarks/>
        public event SuaSEMASTCompletedEventHandler SuaSEMASTCompleted;
        
        /// <remarks/>
        public event XoaCFMASTCompletedEventHandler XoaCFMASTCompleted;
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/ThemSEMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void ThemSEMAST(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate) {
            this.Invoke("ThemSEMAST", new object[] {
                        custid,
                        afacctno,
                        acctno,
                        codeid,
                        totalsellamt,
                        opndate,
                        clsdate,
                        lastdate});
        }
        
        /// <remarks/>
        public void ThemSEMASTAsync(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate) {
            this.ThemSEMASTAsync(custid, afacctno, acctno, codeid, totalsellamt, opndate, clsdate, lastdate, null);
        }
        
        /// <remarks/>
        public void ThemSEMASTAsync(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate, object userState) {
            if ((this.ThemSEMASTOperationCompleted == null)) {
                this.ThemSEMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnThemSEMASTOperationCompleted);
            }
            this.InvokeAsync("ThemSEMAST", new object[] {
                        custid,
                        afacctno,
                        acctno,
                        codeid,
                        totalsellamt,
                        opndate,
                        clsdate,
                        lastdate}, this.ThemSEMASTOperationCompleted, userState);
        }
        
        private void OnThemSEMASTOperationCompleted(object arg) {
            if ((this.ThemSEMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.ThemSEMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/SuaSEMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void SuaSEMAST(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate) {
            this.Invoke("SuaSEMAST", new object[] {
                        custid,
                        afacctno,
                        acctno,
                        codeid,
                        totalsellamt,
                        opndate,
                        clsdate,
                        lastdate});
        }
        
        /// <remarks/>
        public void SuaSEMASTAsync(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate) {
            this.SuaSEMASTAsync(custid, afacctno, acctno, codeid, totalsellamt, opndate, clsdate, lastdate, null);
        }
        
        /// <remarks/>
        public void SuaSEMASTAsync(string custid, string afacctno, string acctno, string codeid, long totalsellamt, System.DateTime opndate, System.DateTime clsdate, System.DateTime lastdate, object userState) {
            if ((this.SuaSEMASTOperationCompleted == null)) {
                this.SuaSEMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnSuaSEMASTOperationCompleted);
            }
            this.InvokeAsync("SuaSEMAST", new object[] {
                        custid,
                        afacctno,
                        acctno,
                        codeid,
                        totalsellamt,
                        opndate,
                        clsdate,
                        lastdate}, this.SuaSEMASTOperationCompleted, userState);
        }
        
        private void OnSuaSEMASTOperationCompleted(object arg) {
            if ((this.SuaSEMASTCompleted != null)) {
                System.Web.Services.Protocols.InvokeCompletedEventArgs invokeArgs = ((System.Web.Services.Protocols.InvokeCompletedEventArgs)(arg));
                this.SuaSEMASTCompleted(this, new System.ComponentModel.AsyncCompletedEventArgs(invokeArgs.Error, invokeArgs.Cancelled, invokeArgs.UserState));
            }
        }
        
        /// <remarks/>
        [System.Web.Services.Protocols.SoapDocumentMethodAttribute("http://tempuri.org/XoaCFMAST", RequestNamespace="http://tempuri.org/", ResponseNamespace="http://tempuri.org/", Use=System.Web.Services.Description.SoapBindingUse.Literal, ParameterStyle=System.Web.Services.Protocols.SoapParameterStyle.Wrapped)]
        public void XoaCFMAST(string custid, string acctno) {
            this.Invoke("XoaCFMAST", new object[] {
                        custid,
                        acctno});
        }
        
        /// <remarks/>
        public void XoaCFMASTAsync(string custid, string acctno) {
            this.XoaCFMASTAsync(custid, acctno, null);
        }
        
        /// <remarks/>
        public void XoaCFMASTAsync(string custid, string acctno, object userState) {
            if ((this.XoaCFMASTOperationCompleted == null)) {
                this.XoaCFMASTOperationCompleted = new System.Threading.SendOrPostCallback(this.OnXoaCFMASTOperationCompleted);
            }
            this.InvokeAsync("XoaCFMAST", new object[] {
                        custid,
                        acctno}, this.XoaCFMASTOperationCompleted, userState);
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
    public delegate void ThemSEMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void SuaSEMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
    
    /// <remarks/>
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.Web.Services", "4.8.4084.0")]
    public delegate void XoaCFMASTCompletedEventHandler(object sender, System.ComponentModel.AsyncCompletedEventArgs e);
}

#pragma warning restore 1591