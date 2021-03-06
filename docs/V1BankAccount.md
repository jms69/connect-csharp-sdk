# Square.Connect.Model.V1BankAccount
## Properties

Name | Type | Description | Notes
------------ | ------------- | ------------- | -------------
**Id** | **string** | The bank account&#39;s Square-issued ID. | [optional] 
**MerchantId** | **string** | The Square-issued ID of the merchant associated with the bank account. | [optional] 
**BankName** | **string** | The name of the bank that manages the account. | [optional] 
**Name** | **string** | The name associated with the bank account. | [optional] 
**RoutingNumber** | **string** | The bank account&#39;s routing number. | [optional] 
**AccountNumberSuffix** | **string** | The last few digits of the bank account number. | [optional] 
**CurrencyCode** | **string** | The currency code of the currency associated with the bank account, in ISO 4217 format. For example, the currency code for US dollars is USD. | [optional] 
**Type** | **TypeEnum** | The bank account&#39;s type (for example, savings or checking). | [optional] 


## TypeEnum

Name | Value
------------ | -------------
**BUSINESSCHECKING** | "BUSINESS_CHECKING"
**CHECKING** | "CHECKING"
**INVESTMENT** | "INVESTMENT"
**LOAN** | "LOAN"
**SAVINGS** | "SAVINGS"
**OTHER** | "OTHER"



[[Back to Model list]](../README.md#documentation-for-models) [[Back to API list]](../README.md#documentation-for-api-endpoints) [[Back to README]](../README.md)

