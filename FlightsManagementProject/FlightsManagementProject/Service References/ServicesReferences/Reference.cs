﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.1
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace FlightsManagementProject.ServicesReferences {
    
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    [System.ServiceModel.ServiceContractAttribute(ConfigurationName="ServicesReferences.IService1")]
    public interface IService1 {
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridDelay_Cause", ReplyAction="http://tempuri.org/IService1/GetGridDelay_CauseResponse")]
        System.Data.DataSet GetGridDelay_Cause(int flightID);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDelay_Cause", ReplyAction="http://tempuri.org/IService1/UpdateDelay_CauseResponse")]
        bool UpdateDelay_Cause(short type, string Description, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDelay_Cause", ReplyAction="http://tempuri.org/IService1/InsertDelay_CauseResponse")]
        bool InsertDelay_Cause(short type, int FlightID, string Description, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser", ReplyAction="http://tempuri.org/IService1/DeleteUserResponse")]
        bool DeleteUser(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridUser", ReplyAction="http://tempuri.org/IService1/GetGridUserResponse")]
        System.Data.DataSet GetGridUser(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetUserAirport", ReplyAction="http://tempuri.org/IService1/GetUserAirportResponse")]
        string GetUserAirport(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser", ReplyAction="http://tempuri.org/IService1/UpdateUserResponse")]
        bool UpdateUser(string username, string password, int phone, string fname, string lname, short type, string airport, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUser", ReplyAction="http://tempuri.org/IService1/InsertUserResponse")]
        bool InsertUser(string username, string password, int phone, string fname, string lname, short type, string airport, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteUser_Type", ReplyAction="http://tempuri.org/IService1/DeleteUser_TypeResponse")]
        bool DeleteUser_Type(short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboUser_Type", ReplyAction="http://tempuri.org/IService1/GetComboUser_TypeResponse")]
        System.Data.DataSet GetComboUser_Type();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateUser_Type", ReplyAction="http://tempuri.org/IService1/UpdateUser_TypeResponse")]
        bool UpdateUser_Type(string name, short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertUser_Type", ReplyAction="http://tempuri.org/IService1/InsertUser_TypeResponse")]
        bool InsertUser_Type(string name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteFlight", ReplyAction="http://tempuri.org/IService1/DeleteFlightResponse")]
        bool DeleteFlight(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridAllFlight", ReplyAction="http://tempuri.org/IService1/GetGridAllFlightResponse")]
        System.Data.DataSet GetGridAllFlight(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridPassengerFlight", ReplyAction="http://tempuri.org/IService1/GetGridPassengerFlightResponse")]
        System.Data.DataSet GetGridPassengerFlight(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridCargoFlight", ReplyAction="http://tempuri.org/IService1/GetGridCargoFlightResponse")]
        System.Data.DataSet GetGridCargoFlight(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateFlight", ReplyAction="http://tempuri.org/IService1/UpdateFlightResponse")]
        bool UpdateFlight(
                    int FID, 
                    System.DateTime schDTFlight, 
                    string DTFlight, 
                    int Load, 
                    int FuelVolume, 
                    bool isScheduled, 
                    bool isLocal, 
                    bool isCharter, 
                    string Airplane, 
                    string Beneficiary, 
                    int Route, 
                    bool Telescope, 
                    int infants, 
                    int childs, 
                    int adults, 
                    int Original_ID, 
                    string usr, 
                    string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertFlight", ReplyAction="http://tempuri.org/IService1/InsertFlightResponse")]
        bool InsertFlight(
                    int FID, 
                    System.DateTime schDTFlight, 
                    string DTFlight, 
                    int Load, 
                    int FuelVolume, 
                    bool isScheduled, 
                    bool isLocal, 
                    bool isCharter, 
                    string Airplane, 
                    string Beneficiary, 
                    int Route, 
                    string username, 
                    string password, 
                    bool Telescope, 
                    int infants, 
                    int childs, 
                    int adults);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/Login", ReplyAction="http://tempuri.org/IService1/LoginResponse")]
        bool[] Login(string username, string password);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAllComponents", ReplyAction="http://tempuri.org/IService1/GetAllComponentsResponse")]
        System.Data.DataSet GetAllComponents();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccessForms", ReplyAction="http://tempuri.org/IService1/GetAccessFormsResponse")]
        bool[] GetAccessForms(short type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAccessComponents", ReplyAction="http://tempuri.org/IService1/GetAccessComponentsResponse")]
        bool[] GetAccessComponents(short type);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAccessForms", ReplyAction="http://tempuri.org/IService1/UpdateAccessFormsResponse")]
        bool UpdateAccessForms(short[] forms, short type, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAccessComponents", ReplyAction="http://tempuri.org/IService1/UpdateAccessComponentsResponse")]
        bool UpdateAccessComponents(int[] components, short type, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirline_types", ReplyAction="http://tempuri.org/IService1/InsertAirline_typesResponse")]
        bool InsertAirline_types(string Name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteRoutes", ReplyAction="http://tempuri.org/IService1/DeleteRoutesResponse")]
        bool DeleteRoutes(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboRoutes", ReplyAction="http://tempuri.org/IService1/GetComboRoutesResponse")]
        System.Data.DataSet GetComboRoutes(string begining, string destination);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridRoutes", ReplyAction="http://tempuri.org/IService1/GetGridRoutesResponse")]
        System.Data.DataSet GetGridRoutes(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateRoutes", ReplyAction="http://tempuri.org/IService1/UpdateRoutesResponse")]
        bool UpdateRoutes(string name, int Distance, string Beginning_Airport, string Destination_Airport, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertRoutes", ReplyAction="http://tempuri.org/IService1/InsertRoutesResponse")]
        bool InsertRoutes(string name, int Distance, string Beginning_Airport, string Destination_Airport, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirplane", ReplyAction="http://tempuri.org/IService1/DeleteAirplaneResponse")]
        bool DeleteAirplane(string Original_Register, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirplane", ReplyAction="http://tempuri.org/IService1/GetComboAirplaneResponse")]
        System.Data.DataSet GetComboAirplane();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridAirplane", ReplyAction="http://tempuri.org/IService1/GetGridAirplaneResponse")]
        System.Data.DataSet GetGridAirplane(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetAirplaneOwner", ReplyAction="http://tempuri.org/IService1/GetAirplaneOwnerResponse")]
        string GetAirplaneOwner(string Register);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirplane", ReplyAction="http://tempuri.org/IService1/UpdateAirplaneResponse")]
        bool UpdateAirplane(string Register, int Serial, string Made_Date, int Model, short Usage_Type, string Owner, string Original_Register, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirplane", ReplyAction="http://tempuri.org/IService1/InsertAirplaneResponse")]
        bool InsertAirplane(string Register, int Serial, System.DateTime Made_Date, int Model, short Usage_Type, string Owner, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirplane_Model", ReplyAction="http://tempuri.org/IService1/DeleteAirplane_ModelResponse")]
        bool DeleteAirplane_Model(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirplane_Model", ReplyAction="http://tempuri.org/IService1/GetComboAirplane_ModelResponse")]
        System.Data.DataSet GetComboAirplane_Model();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridAirplane_Model", ReplyAction="http://tempuri.org/IService1/GetGridAirplane_ModelResponse")]
        System.Data.DataSet GetGridAirplane_Model(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirplane_Model", ReplyAction="http://tempuri.org/IService1/UpdateAirplane_ModelResponse")]
        bool UpdateAirplane_Model(string Name, short Capacity, int MTOW, int Weight, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirplane_Model", ReplyAction="http://tempuri.org/IService1/InsertAirplane_ModelResponse")]
        bool InsertAirplane_Model(string Name, short Capacity, int MTOW, int Weight, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirplane_Usage", ReplyAction="http://tempuri.org/IService1/DeleteAirplane_UsageResponse")]
        bool DeleteAirplane_Usage(short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirplane_Usage", ReplyAction="http://tempuri.org/IService1/GetComboAirplane_UsageResponse")]
        System.Data.DataSet GetComboAirplane_Usage();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirplane_Usage", ReplyAction="http://tempuri.org/IService1/UpdateAirplane_UsageResponse")]
        bool UpdateAirplane_Usage(string Name, short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirplane_Usage", ReplyAction="http://tempuri.org/IService1/InsertAirplane_UsageResponse")]
        bool InsertAirplane_Usage(string Name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteDelay_Type", ReplyAction="http://tempuri.org/IService1/DeleteDelay_TypeResponse")]
        bool DeleteDelay_Type(short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboDelay_Type", ReplyAction="http://tempuri.org/IService1/GetComboDelay_TypeResponse")]
        System.Data.DataSet GetComboDelay_Type();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateDelay_Type", ReplyAction="http://tempuri.org/IService1/UpdateDelay_TypeResponse")]
        bool UpdateDelay_Type(string Name, short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertDelay_Type", ReplyAction="http://tempuri.org/IService1/InsertDelay_TypeResponse")]
        bool InsertDelay_Type(string Name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirport", ReplyAction="http://tempuri.org/IService1/DeleteAirportResponse")]
        bool DeleteAirport(string Original_Code3, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirport", ReplyAction="http://tempuri.org/IService1/GetComboAirportResponse")]
        System.Data.DataSet GetComboAirport();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridAirport", ReplyAction="http://tempuri.org/IService1/GetGridAirportResponse")]
        System.Data.DataSet GetGridAirport(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirport", ReplyAction="http://tempuri.org/IService1/UpdateAirportResponse")]
        bool UpdateAirport(string Code3, string Code4, int CiryID, string Pers_Name, string Eng_Name, short TypeID, string Original_Code3, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirport", ReplyAction="http://tempuri.org/IService1/InsertAirportResponse")]
        bool InsertAirport(string Code3, string Code4, int CiryID, string Pers_Name, string Eng_Name, short TypeID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirport_Types", ReplyAction="http://tempuri.org/IService1/DeleteAirport_TypesResponse")]
        bool DeleteAirport_Types(short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirport_types", ReplyAction="http://tempuri.org/IService1/GetComboAirport_typesResponse")]
        System.Data.DataSet GetComboAirport_types();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirport_Types", ReplyAction="http://tempuri.org/IService1/UpdateAirport_TypesResponse")]
        bool UpdateAirport_Types(string Name, short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirport_Types", ReplyAction="http://tempuri.org/IService1/InsertAirport_TypesResponse")]
        bool InsertAirport_Types(string Name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCity", ReplyAction="http://tempuri.org/IService1/DeleteCityResponse")]
        bool DeleteCity(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboCity", ReplyAction="http://tempuri.org/IService1/GetComboCityResponse")]
        System.Data.DataSet GetComboCity();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCity", ReplyAction="http://tempuri.org/IService1/UpdateCityResponse")]
        bool UpdateCity(string Name, int CountryID, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertCity", ReplyAction="http://tempuri.org/IService1/InsertCityResponse")]
        bool InsertCity(string Name, int CountryID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteCounty", ReplyAction="http://tempuri.org/IService1/DeleteCountyResponse")]
        bool DeleteCounty(int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboCountry", ReplyAction="http://tempuri.org/IService1/GetComboCountryResponse")]
        System.Data.DataSet GetComboCountry();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateCountry", ReplyAction="http://tempuri.org/IService1/UpdateCountryResponse")]
        bool UpdateCountry(string Name, int Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertCountry", ReplyAction="http://tempuri.org/IService1/InsertCountryResponse")]
        bool InsertCountry(string Name, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirline", ReplyAction="http://tempuri.org/IService1/DeleteAirlineResponse")]
        bool DeleteAirline(string Original_code3, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirline", ReplyAction="http://tempuri.org/IService1/GetComboAirlineResponse")]
        System.Data.DataSet GetComboAirline();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetGridAirline", ReplyAction="http://tempuri.org/IService1/GetGridAirlineResponse")]
        System.Data.DataSet GetGridAirline(string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirline", ReplyAction="http://tempuri.org/IService1/UpdateAirlineResponse")]
        bool UpdateAirline(string code3, string Code4, string Eng_Name, string Pers_Name, short Type, int Country, string Original_code3, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/InsertAirline", ReplyAction="http://tempuri.org/IService1/InsertAirlineResponse")]
        bool InsertAirline(string code3, string Code4, string Eng_Name, string Pers_Name, short Type, int Country, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/DeleteAirline_types", ReplyAction="http://tempuri.org/IService1/DeleteAirline_typesResponse")]
        bool DeleteAirline_types(short Original_ID, string usr, string pass);
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/GetComboAirline_types", ReplyAction="http://tempuri.org/IService1/GetComboAirline_typesResponse")]
        System.Data.DataSet GetComboAirline_types();
        
        [System.ServiceModel.OperationContractAttribute(Action="http://tempuri.org/IService1/UpdateAirline_types", ReplyAction="http://tempuri.org/IService1/UpdateAirline_typesResponse")]
        bool UpdateAirline_types(string Name, short Original_ID, string usr, string pass);
    }
    
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public interface IService1Channel : FlightsManagementProject.ServicesReferences.IService1, System.ServiceModel.IClientChannel {
    }
    
    [System.Diagnostics.DebuggerStepThroughAttribute()]
    [System.CodeDom.Compiler.GeneratedCodeAttribute("System.ServiceModel", "4.0.0.0")]
    public partial class Service1Client : System.ServiceModel.ClientBase<FlightsManagementProject.ServicesReferences.IService1>, FlightsManagementProject.ServicesReferences.IService1 {
        
        public Service1Client() {
        }
        
        public Service1Client(string endpointConfigurationName) : 
                base(endpointConfigurationName) {
        }
        
        public Service1Client(string endpointConfigurationName, string remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(string endpointConfigurationName, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(endpointConfigurationName, remoteAddress) {
        }
        
        public Service1Client(System.ServiceModel.Channels.Binding binding, System.ServiceModel.EndpointAddress remoteAddress) : 
                base(binding, remoteAddress) {
        }
        
        public System.Data.DataSet GetGridDelay_Cause(int flightID) {
            return base.Channel.GetGridDelay_Cause(flightID);
        }
        
        public bool UpdateDelay_Cause(short type, string Description, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateDelay_Cause(type, Description, Original_ID, usr, pass);
        }
        
        public bool InsertDelay_Cause(short type, int FlightID, string Description, string usr, string pass) {
            return base.Channel.InsertDelay_Cause(type, FlightID, Description, usr, pass);
        }
        
        public bool DeleteUser(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteUser(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetGridUser(string usr, string pass) {
            return base.Channel.GetGridUser(usr, pass);
        }
        
        public string GetUserAirport(string username, string password) {
            return base.Channel.GetUserAirport(username, password);
        }
        
        public bool UpdateUser(string username, string password, int phone, string fname, string lname, short type, string airport, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateUser(username, password, phone, fname, lname, type, airport, Original_ID, usr, pass);
        }
        
        public bool InsertUser(string username, string password, int phone, string fname, string lname, short type, string airport, string usr, string pass) {
            return base.Channel.InsertUser(username, password, phone, fname, lname, type, airport, usr, pass);
        }
        
        public bool DeleteUser_Type(short Original_ID, string usr, string pass) {
            return base.Channel.DeleteUser_Type(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboUser_Type() {
            return base.Channel.GetComboUser_Type();
        }
        
        public bool UpdateUser_Type(string name, short Original_ID, string usr, string pass) {
            return base.Channel.UpdateUser_Type(name, Original_ID, usr, pass);
        }
        
        public bool InsertUser_Type(string name, string usr, string pass) {
            return base.Channel.InsertUser_Type(name, usr, pass);
        }
        
        public bool DeleteFlight(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteFlight(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetGridAllFlight(string usr, string pass) {
            return base.Channel.GetGridAllFlight(usr, pass);
        }
        
        public System.Data.DataSet GetGridPassengerFlight(string usr, string pass) {
            return base.Channel.GetGridPassengerFlight(usr, pass);
        }
        
        public System.Data.DataSet GetGridCargoFlight(string usr, string pass) {
            return base.Channel.GetGridCargoFlight(usr, pass);
        }
        
        public bool UpdateFlight(
                    int FID, 
                    System.DateTime schDTFlight, 
                    string DTFlight, 
                    int Load, 
                    int FuelVolume, 
                    bool isScheduled, 
                    bool isLocal, 
                    bool isCharter, 
                    string Airplane, 
                    string Beneficiary, 
                    int Route, 
                    bool Telescope, 
                    int infants, 
                    int childs, 
                    int adults, 
                    int Original_ID, 
                    string usr, 
                    string pass) {
            return base.Channel.UpdateFlight(FID, schDTFlight, DTFlight, Load, FuelVolume, isScheduled, isLocal, isCharter, Airplane, Beneficiary, Route, Telescope, infants, childs, adults, Original_ID, usr, pass);
        }
        
        public bool InsertFlight(
                    int FID, 
                    System.DateTime schDTFlight, 
                    string DTFlight, 
                    int Load, 
                    int FuelVolume, 
                    bool isScheduled, 
                    bool isLocal, 
                    bool isCharter, 
                    string Airplane, 
                    string Beneficiary, 
                    int Route, 
                    string username, 
                    string password, 
                    bool Telescope, 
                    int infants, 
                    int childs, 
                    int adults) {
            return base.Channel.InsertFlight(FID, schDTFlight, DTFlight, Load, FuelVolume, isScheduled, isLocal, isCharter, Airplane, Beneficiary, Route, username, password, Telescope, infants, childs, adults);
        }
        
        public bool[] Login(string username, string password) {
            return base.Channel.Login(username, password);
        }
        
        public System.Data.DataSet GetAllComponents() {
            return base.Channel.GetAllComponents();
        }
        
        public bool[] GetAccessForms(short type) {
            return base.Channel.GetAccessForms(type);
        }
        
        public bool[] GetAccessComponents(short type) {
            return base.Channel.GetAccessComponents(type);
        }
        
        public bool UpdateAccessForms(short[] forms, short type, string usr, string pass) {
            return base.Channel.UpdateAccessForms(forms, type, usr, pass);
        }
        
        public bool UpdateAccessComponents(int[] components, short type, string usr, string pass) {
            return base.Channel.UpdateAccessComponents(components, type, usr, pass);
        }
        
        public bool InsertAirline_types(string Name, string usr, string pass) {
            return base.Channel.InsertAirline_types(Name, usr, pass);
        }
        
        public bool DeleteRoutes(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteRoutes(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboRoutes(string begining, string destination) {
            return base.Channel.GetComboRoutes(begining, destination);
        }
        
        public System.Data.DataSet GetGridRoutes(string usr, string pass) {
            return base.Channel.GetGridRoutes(usr, pass);
        }
        
        public bool UpdateRoutes(string name, int Distance, string Beginning_Airport, string Destination_Airport, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateRoutes(name, Distance, Beginning_Airport, Destination_Airport, Original_ID, usr, pass);
        }
        
        public bool InsertRoutes(string name, int Distance, string Beginning_Airport, string Destination_Airport, string usr, string pass) {
            return base.Channel.InsertRoutes(name, Distance, Beginning_Airport, Destination_Airport, usr, pass);
        }
        
        public bool DeleteAirplane(string Original_Register, string usr, string pass) {
            return base.Channel.DeleteAirplane(Original_Register, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirplane() {
            return base.Channel.GetComboAirplane();
        }
        
        public System.Data.DataSet GetGridAirplane(string usr, string pass) {
            return base.Channel.GetGridAirplane(usr, pass);
        }
        
        public string GetAirplaneOwner(string Register) {
            return base.Channel.GetAirplaneOwner(Register);
        }
        
        public bool UpdateAirplane(string Register, int Serial, string Made_Date, int Model, short Usage_Type, string Owner, string Original_Register, string usr, string pass) {
            return base.Channel.UpdateAirplane(Register, Serial, Made_Date, Model, Usage_Type, Owner, Original_Register, usr, pass);
        }
        
        public bool InsertAirplane(string Register, int Serial, System.DateTime Made_Date, int Model, short Usage_Type, string Owner, string usr, string pass) {
            return base.Channel.InsertAirplane(Register, Serial, Made_Date, Model, Usage_Type, Owner, usr, pass);
        }
        
        public bool DeleteAirplane_Model(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteAirplane_Model(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirplane_Model() {
            return base.Channel.GetComboAirplane_Model();
        }
        
        public System.Data.DataSet GetGridAirplane_Model(string usr, string pass) {
            return base.Channel.GetGridAirplane_Model(usr, pass);
        }
        
        public bool UpdateAirplane_Model(string Name, short Capacity, int MTOW, int Weight, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateAirplane_Model(Name, Capacity, MTOW, Weight, Original_ID, usr, pass);
        }
        
        public bool InsertAirplane_Model(string Name, short Capacity, int MTOW, int Weight, string usr, string pass) {
            return base.Channel.InsertAirplane_Model(Name, Capacity, MTOW, Weight, usr, pass);
        }
        
        public bool DeleteAirplane_Usage(short Original_ID, string usr, string pass) {
            return base.Channel.DeleteAirplane_Usage(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirplane_Usage() {
            return base.Channel.GetComboAirplane_Usage();
        }
        
        public bool UpdateAirplane_Usage(string Name, short Original_ID, string usr, string pass) {
            return base.Channel.UpdateAirplane_Usage(Name, Original_ID, usr, pass);
        }
        
        public bool InsertAirplane_Usage(string Name, string usr, string pass) {
            return base.Channel.InsertAirplane_Usage(Name, usr, pass);
        }
        
        public bool DeleteDelay_Type(short Original_ID, string usr, string pass) {
            return base.Channel.DeleteDelay_Type(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboDelay_Type() {
            return base.Channel.GetComboDelay_Type();
        }
        
        public bool UpdateDelay_Type(string Name, short Original_ID, string usr, string pass) {
            return base.Channel.UpdateDelay_Type(Name, Original_ID, usr, pass);
        }
        
        public bool InsertDelay_Type(string Name, string usr, string pass) {
            return base.Channel.InsertDelay_Type(Name, usr, pass);
        }
        
        public bool DeleteAirport(string Original_Code3, string usr, string pass) {
            return base.Channel.DeleteAirport(Original_Code3, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirport() {
            return base.Channel.GetComboAirport();
        }
        
        public System.Data.DataSet GetGridAirport(string usr, string pass) {
            return base.Channel.GetGridAirport(usr, pass);
        }
        
        public bool UpdateAirport(string Code3, string Code4, int CiryID, string Pers_Name, string Eng_Name, short TypeID, string Original_Code3, string usr, string pass) {
            return base.Channel.UpdateAirport(Code3, Code4, CiryID, Pers_Name, Eng_Name, TypeID, Original_Code3, usr, pass);
        }
        
        public bool InsertAirport(string Code3, string Code4, int CiryID, string Pers_Name, string Eng_Name, short TypeID, string usr, string pass) {
            return base.Channel.InsertAirport(Code3, Code4, CiryID, Pers_Name, Eng_Name, TypeID, usr, pass);
        }
        
        public bool DeleteAirport_Types(short Original_ID, string usr, string pass) {
            return base.Channel.DeleteAirport_Types(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirport_types() {
            return base.Channel.GetComboAirport_types();
        }
        
        public bool UpdateAirport_Types(string Name, short Original_ID, string usr, string pass) {
            return base.Channel.UpdateAirport_Types(Name, Original_ID, usr, pass);
        }
        
        public bool InsertAirport_Types(string Name, string usr, string pass) {
            return base.Channel.InsertAirport_Types(Name, usr, pass);
        }
        
        public bool DeleteCity(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteCity(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboCity() {
            return base.Channel.GetComboCity();
        }
        
        public bool UpdateCity(string Name, int CountryID, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateCity(Name, CountryID, Original_ID, usr, pass);
        }
        
        public bool InsertCity(string Name, int CountryID, string usr, string pass) {
            return base.Channel.InsertCity(Name, CountryID, usr, pass);
        }
        
        public bool DeleteCounty(int Original_ID, string usr, string pass) {
            return base.Channel.DeleteCounty(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboCountry() {
            return base.Channel.GetComboCountry();
        }
        
        public bool UpdateCountry(string Name, int Original_ID, string usr, string pass) {
            return base.Channel.UpdateCountry(Name, Original_ID, usr, pass);
        }
        
        public bool InsertCountry(string Name, string usr, string pass) {
            return base.Channel.InsertCountry(Name, usr, pass);
        }
        
        public bool DeleteAirline(string Original_code3, string usr, string pass) {
            return base.Channel.DeleteAirline(Original_code3, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirline() {
            return base.Channel.GetComboAirline();
        }
        
        public System.Data.DataSet GetGridAirline(string usr, string pass) {
            return base.Channel.GetGridAirline(usr, pass);
        }
        
        public bool UpdateAirline(string code3, string Code4, string Eng_Name, string Pers_Name, short Type, int Country, string Original_code3, string usr, string pass) {
            return base.Channel.UpdateAirline(code3, Code4, Eng_Name, Pers_Name, Type, Country, Original_code3, usr, pass);
        }
        
        public bool InsertAirline(string code3, string Code4, string Eng_Name, string Pers_Name, short Type, int Country, string usr, string pass) {
            return base.Channel.InsertAirline(code3, Code4, Eng_Name, Pers_Name, Type, Country, usr, pass);
        }
        
        public bool DeleteAirline_types(short Original_ID, string usr, string pass) {
            return base.Channel.DeleteAirline_types(Original_ID, usr, pass);
        }
        
        public System.Data.DataSet GetComboAirline_types() {
            return base.Channel.GetComboAirline_types();
        }
        
        public bool UpdateAirline_types(string Name, short Original_ID, string usr, string pass) {
            return base.Channel.UpdateAirline_types(Name, Original_ID, usr, pass);
        }
    }
}