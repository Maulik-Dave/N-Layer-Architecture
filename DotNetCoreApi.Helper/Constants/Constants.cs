namespace DotNetCoreApi.Helper.Constants
{
    /* This class is use to define the Constants for Common Fields. */
    public static class Constants
    {
        public static string Unauthorized
        {
            get { return "You do not have permission to access it. Please contact Administrator"; }
        }

        public static string Token
        {
            get { return "Token"; }
        }

        public static string ServerToken
        {
            get { return "WTdta2dNYy9DeXVxeEgvZmJ5Ulh1a3c3UTNzR3ZZWTRhejcvUXNFZ25jTT06MTo2MzcyMjU0NjAwMjMyNTgyODI6MTow"; }
        }

        public static string NotDeleted
        {
            get { return "N"; }
        }
        public static string Deleted
        {
            get { return "Y"; }
        }
        public static DateTime CurrentDateTime
        {
            get { return System.DateTime.UtcNow; }
        }
        public static string CurrentUser
        {
            get { return "Admin"; }

        }
        public static int CurrentBranch
        {
            get { return 1; }
        }
        public static int CurrentCompany
        {
            get { return 1; }
        }
        public static string TokenKeyWord
        {
            get { return "Token"; }
        }

        public static string WithReferenceModel
        {
            get { return "WRefModels"; }
        }

        public static string WithOutReferenceModel
        {
            get { return "WORefModels"; }
        }


        public static string DateTimeForDocument
        {
            get { return DateTime.UtcNow.ToString("yyyyMMddHHmmssffff"); }
        }


        public static string ProductCatrgoryPesticides
        {
            get { return "Pesticides"; }
        }

        public static string ProductCatrgoryPestControlService
        {
            get { return "Pest Control Service"; }
        }


        public static string gmailaccountusername
        {
            get { return "gmail.account.username"; }
        }
        public static string gmailaccountpassword
        {
            get { return "gmail.account.password"; }
        }
        public static string marketingworkassignment
        {
            get { return "marketing.work.assignment"; }
        }
        public static string salesworkassignment
        {
            get { return "sales.work.assignment"; }
        }
        public static string warehouseworkassignment
        {
            get { return "warehouse.work.assignment"; }
        }
        public static double warehouseinquiryrate
        {
            get { return 0.0; }
        }
        public static string accountingpaymentpayable
        {
            get { return "accounting.payment.payable"; }
        }
        public static string accountingpaymentreceivable
        {
            get { return "accounting.payment.receivable"; }
        }
        public static int marketingworkassignmentdistance
        {
            get { return 5; }
        }
        public static bool IsAutoPayment
        {
            get { return true; }
        }
        public static bool IsAutoEmailSendForPurchase
        {
            get { return true; }
        }
        public static string Currency
        {
            get { return "Currency"; }
        }
        public static string ModuleID
        {
            get { return "ModuleID"; }
        }
        public static string CustomerAccountIdForGlance
        {
            get { return "CustomerAccountIdForGlance"; }
        }
        public static string Desktop
        {
            get { return "Desktop"; }
        }
        public static string MobileApp
        {
            get { return "Mobile App"; }
        }
        public static int CustomerUser
        {
            get { return 2; }
        }
        public static int SystemUser
        {
            get { return 1; }
        }
        public static string DayShiftStart
        {
            get { return "6:00 AM"; }
        }
        public static string DayShiftEnd
        {
            get { return "5:59 PM"; }
        }
        public static string EveningShiftStart
        {
            get { return "6:00 PM"; }
        }
        public static string EveningShiftEnd
        {
            get { return "11:59 PM"; }
        }
        public static string NightShiftStart
        {
            get { return "12:00 AM"; }
        }
        public static string NightShiftEnd
        {
            get { return "5:59 AM"; }
        }
        public static string DayShift
        {
            get { return "Day"; }
        }
        public static string EveningShift
        {
            get { return "Evening"; }
        }
        public static string NightShift
        {
            get { return "Night"; }
        }
        public static string BranchCurrencySymbol
        {
            get { return "Currency Symbol"; }
        }
        public static string BranchCulture
        {
            get { return "Culture"; }
        }
        public static string BranchIsMetric
        {
            get { return "Is Metric"; }
        }
        public static string BranchTimeZone
        {
            get { return "Time Zone"; }
        }
        public static string CurrencyID
        {
            get { return "Currency ID"; }
        }

        public static string IsImperialUnit
        {
            get { return "Imperial"; }
        }
        public static string IsMetricUnit
        {
            get { return "Metric"; }
        }
        public static string CurrentOwed
        {
            get { return "Paymnet Due From Less Then 30 Days"; }
        }
        public static string Over30DaysOwed
        {
            get { return "Paymnet Due From 30 To 60 Days"; }
        }
        public static string Over60DaysOwed
        {
            get { return "Paymnet Due From 60 To 90 Days"; }
        }
        public static string Over90DaysOwed
        {
            get { return "Paymnet Due From More Then 90 Days"; }
        }
        public static string AllDays
        {
            get { return "AllDays"; }
        }
        public static string CultureString
        {
            get { return "Culture"; }
        }
        public static string TimeZoneString
        {
            get { return "TimeZone"; }
        }
        public static string IsGovernmentSubscription
        {
            get { return "Is Government Subscription"; }
        }
        public static string BCPDefaultAreaMeasurement
        {
            get { return "Default Area Measurement"; }
        }
        public static string BCPStartDayOfWeek
        {
            get { return "Start Day Of Week"; }
        }
        public static string BCPCalculateSalaryOnWeeklyBasis
        {
            get { return "Calculate Salary On Weekly Basis"; }
        }
        public static string BCPWarningThresholdHours
        {
            get { return "Warning Threshold Hours"; }
        }
        public static string BCPQuotationFollowupDays
        {
            get { return "Quotation Follow up after days"; }
        }
        public static string BCPInvoiceFollowupDays
        {
            get { return "Invoice Follow up after days"; }
        }
        public static string BCPContractFollowupDays
        {
            get { return "Contract Follow up after days"; }
        }
        public static string MainThemeColor
        {
            get { return "Main Theme Color"; }
        }
        public static string SuccessButtonColor
        {
            get { return "Success Button Color"; }
        }
        public static string CancelButtonColor
        {
            get { return "Cancel Button Color"; }
        }
        public static string LinkColor
        {
            get { return "Link Color"; }
        }
        public static string CustomerThere
        {
            get { return "there"; }
        }
        public static string ServiceTicket
        {
            get { return "ST"; }
        }
        public static string ServiceRequest
        {
            get { return "SR"; }
        }

        public static string LaborCost
        {
            get { return "LaborCost"; }
        }
        public static string OtherCost
        {
            get { return "OtherCost"; }
        }
        public static string LumpsumCost
        {
            get { return "Other"; }
        }
        public static string Add
        {
            get { return "Add"; }
        }
        public static string NotAdd
        {
            get { return "NotAdd"; }
        }
        public static string IsCustomer
        {
            get { return "IsCustomer"; }
        }
        public static string FiscalYearStartMonth
        {
            get { return "Fiscal Year Start Month"; }
        }

        public static string ConfigJsonFile
        {
            get { return "~/App_Data/Config.json"; }
        }

        public static string GeorgiaPest1
        {
            get { return "Subterranean Termites"; }
        }

        public static string GeorgiaPest2
        {
            get { return "Powder Post Beetles"; }
        }

        public static string GeorgiaPest3
        {
            get { return "Wood Boring Beetles"; }
        }

        public static string GeorgiaPest4
        {
            //get { return "Dry Wood Termites"; }
            get { return "Drywood Termite"; }
        }

        public static string GeorgiaPest5
        {
            get { return "Wood Decaying Fungus"; }
        }
        public static string ID
        {
            get { return "id"; }
        }
        public static string Status
        {
            get { return "status"; }
        }
        public static string AccountKeyNotFound
        {
            get { return "Account Key Not Found. Please contact administrator"; }
        }
        public static string ServDayServerErrorMsg
        {
            get { return "ServDay Server Connection Error. Please contact administrator"; }
        }
        public static string ServDaySubscriptionErrorMsg
        {
            get { return "You subscription expired"; }
        }
        public static string ServDaySubscriptionExpiredErrorMsg
        {
            get { return "You do not have any active subscription please contact administrator"; }
        }
        public static string UserBaseServDaySubscriptionErrorMsg
        {
            get { return "You do not have vacant seats.please buy new seats for creating users"; }
        }
        public static string SvcBaseServDaySubscriptionErrorMsg
        {
            get { return "You do not have vacant seats.please buy new seats for creating svc"; }
        }
        public static int AccountDevicesForNoOfDayOnMap
        {
            get { return 15; }
        }
        public static string ServerUsername
        {
            get { return "Server Username"; }
        }
        public static string ServerPassword
        {
            get { return "Server Password"; }
        }

        //-------------------- Email Parameters  -------------------------

        public static string EmailSMTPHost
        {
            get { return "Email SMTP Host"; }
        }
        public static string EmailSMTPPort
        {
            get { return "Email SMTP Port"; }
        }
        public static string EmailSSLEnable
        {
            get { return "Email SSL Enable"; }
        }
        public static string EmailUsername
        {
            get { return "Email Username"; }
        }
        public static string EmailPassword
        {
            get { return "Email Password"; }
        }
        public static string EmailSenderName
        {
            get { return "Email Sender Name"; }
        }
        public static string EmailSenderEmail
        {
            get { return "Email Sender Email"; }
        }
        public static string ExternalProduct
        {
            get { return "External"; }
        }

        //-------------------- PayPal Parameters  -------------------------

        public static string PayPalClientID
        {
            get { return "Paypal Client Id"; }
        }
        public static string PayPalClientSecretID
        {
            get { return "Paypal Client Secret"; }
        }
        public static string PayPalMode
        {
            get { return "Paypal Mode"; }
        }
        public static string EmployeeID
        {
            get { return "EmployeeID"; }
        }
        public static string OtherAddressID
        {
            get { return "OtherAddressID"; }
        }
        public static string BillingAddressID
        {
            get { return "BillingAddressID"; }
        }
        public static string CustomerAccountID
        {
            get { return "CustomerAccountID"; }
        }
        public static string DefaultPaymentGateway
        {
            get { return "Default Payment Gateway"; }
        }
        public static string CardConnectUserName
        {
            get { return "Card Connect Username"; }
        }
        public static string CardConnectPassword
        {
            get { return "Card Connect Password"; }
        }
        public static string CardConnectMerchentId
        {
            get { return "Card Connect MerchentId"; }
        }
        public static string CardConnectEndPoint
        {
            get { return "Card Connect End Point"; }
        }
        public static string DefaultGatewayCardConnect
        {
            get { return "Card Connect"; }
        }
        public static string DefaultGatewayPaypal
        {
            get { return "PayPal"; }
        }
        public static string CurrencyISOCode
        {
            get { return "Currency ISO Code"; }
        }
        public static string PaymentGatewayStatusApproved
        {
            get { return "approved"; }
        }
        public static string CardConnectAuthApproval
        {
            get { return "Approval"; }
        }
        public static string CardConnectResponseText
        {
            get { return "resptext"; }
        }
        public static string CardConnectAuthCode
        {
            get { return "retref"; }
        }
        public static string CardConnectResponseCode
        {
            get { return "respcode"; }
        }

        public static string AdminForRole
        {
            get { return "Admin"; }
        }

        public static string SalesAccountSetupOtherAddID
        {
            get { return "SalesAccountSetupOtherAddID"; }
        }
        public static string GenerateQuoteFrmOppID
        {
            get { return "GenerateQuotefrmoppID"; }
        }
        public static string QuotesNameFrmOppID
        {
            get { return "QuotesNameFrmOppID"; }
        }


        #region QBChanges
        public static string QuickbooksBaseUrl
        {
            get { return "QuickbooksBaseUrl"; }
        }
        public static string QuickbookEnvironment
        {
            get { return "QuickbookEnvironment"; }
        }
        public static string QuickBookRedirectUrl
        {
            get { return "QuickBookRedirectUrl"; }
        }
        public static string QuickBookClientSecret
        {
            get { return "QuickBookClientSecret"; }
        }
        public static string QuickBookClientID
        {
            get { return "QuickBookClientID"; }
        }
        public static string IsQuickBookEnable
        {
            get { return "IsQuickBookEnable"; }
        }
        public static string QuickBookRealmID
        {
            get { return "QuickBookRealmID"; }
        }
        public static string QuickBookRefreshTokenExpiresAt
        {
            get { return "QuickBookRefreshTokenExpiresAt"; }
        }
        public static string QuickBookRefreshToken
        {
            get { return "QuickBookRefreshToken"; }
        }
        public static string QuickBookAccessTokenExpiresAt
        {
            get { return "QuickBookAccessTokenExpiresAt"; }
        }
        public static string QuickBookAccessToken
        {
            get { return "QuickBookAccessToken"; }
        }
        #endregion

        public static string AccountKey
        {
            get { return "AccountKey"; }
        }

        public static string JobPostingToken
        {
            get { return "JobPostingToken"; }
        }

        #region "GPM Subscription"
        public static string GPMSubscription
        {
            get { return "GPM Subscription"; }
        }
        #endregion

        #region CompanyConfiguration
        public static string CompanyConfiguration
        {
            get { return "CompanyConfiguration"; }
        }
        public static string InitialSetup
        {
            get { return "InitialSetup"; }
        }
        public static string SubscriptionID
        {
            get { return "SubscriptionID"; }
        }
        public static string ServiceID
        {
            get { return "ServiceID"; }
        }

        public static string StartTasks
        {
            get { return "Start Tasks"; }
        }

        public static string EndTasks
        {
            get { return "End Tasks"; }
        }

        #endregion

        #region Lite Product

        public static int DefaultManufacturer
        {
            get { return 1; }
        }

        #endregion

        #region Lite User

        public static int DefaultDepartment
        {
            get { return 1; }
        }

        #endregion
    }
}
