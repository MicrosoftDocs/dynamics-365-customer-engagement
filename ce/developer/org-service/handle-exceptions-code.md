---
title: "Handle exceptions in your code (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This article discusses the exceptions that are returned from a Dynamics 365 Customer Engagement web service method call. The sample in this article highlights the common faults and exceptions that your application design should handle."
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 02d0ad6c-eb76-4ea9-972f-c7647eef6c09
caps.latest.revision: 28
author: "JimDaly"
ms.author: "jdaly"
manager: "jdaly"
---
# Handle exceptions in your code
There are a number of exceptions that can be returned from a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement web service method call. Your application design must catch and appropriately handle these exceptions. In the [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)], all web service method calls use a communication channel to the server based on the [!INCLUDE[pn_WCF_long](../../includes/pn-wcf-long.md)] technology. In WCF terms, exceptions returned from the channel are called *faults*.  

<a name="BKMK_Common"></a>   
## Common exceptions and faults  
 The following code is used in most [!INCLUDE[pn_sdk](../../includes/pn-sdk.md)] samples. It highlights the common faults and exceptions that your application design should handle.  
  
 [!code-csharp[StrongTypes#CRUDOperations2](../../snippets/csharp/CRMV8/strongtypes/cs/crudoperations2.cs#crudoperations2)]  
  
> [!NOTE]
>  If you’re accessing the Discovery web service, your code should catch <xref:Microsoft.Xrm.Sdk.DiscoveryServiceFault> instead of the <xref:Microsoft.Xrm.Sdk.OrganizationServiceFault> fault shown previously.  
  
 In addition to these exceptions and faults, your code must handle the following exceptions:  
  
-   [SecurityTokenValidationException](https://msdn.microsoft.com/library/system.identitymodel.tokens.securitytokenvalidationexception.aspx)  
  
-   [ExpiredSecurityTokenException](https://msdn.microsoft.com/library/system.servicemodel.security.expiredsecuritytokenexception.aspx)  
  
-   [SecurityAccessDeniedException](https://msdn.microsoft.com/library/system.servicemodel.security.securityaccessdeniedexception.aspx)  
  
-   [MessageSecurityException](https://msdn.microsoft.com/library/system.servicemodel.security.messagesecurityexception.aspx)  
  
-   [SecurityNegotiationException](https://msdn.microsoft.com/library/system.servicemodel.security.securitynegotiationexception.aspx)  
  
 When connecting to [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], a `SecurityAccessDeniedException` exception can be thrown if you use a valid [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] and your account is not associated with any [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization. A `MessageSecurityException` can be thrown if your [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] isn’t valid or there was an authentication failure.  
  
<a name="BKMK_BusinessRuleErrors"></a>   
## Custom errors from business rules  
 With [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] and [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)], customizers can create business rules that are evaluated on the server. Customizers can throw error messages based on conditions set in the business rule. Developers should be sure to include robust error handling in their code to catch and handle these exceptions.  
  
 The following is an example of the trace log produced when one of these errors is returned from a business rule named “Name of Entity Scope Business Rule returning Error” and the error message is “custom error message”.  
  
```  
Unhandled Exception: System.ServiceModel.FaultException`1[[Microsoft.Xrm.Sdk.OrganizationServiceFault, Microsoft.Xrm.Sdk, Version=7.0.0.0, Culture=neutral, PublicKeyToken=31bf3856ad364e35]]: custom error messageDetail:   
<OrganizationServiceFault xmlns:i="http://www.w3.org/2001/XMLSchema-instance" xmlns="http://schemas.microsoft.com/xrm/2011/Contracts">  
  <ErrorCode>-2147220891</ErrorCode>  
  <ErrorDetails xmlns:d2p1="http://schemas.datacontract.org/2004/07/System.Collections.Generic">  
    <KeyValuePairOfstringanyType>  
      <d2p1:key>OperationStatus</d2p1:key>  
      <d2p1:value xmlns:d4p1="http://www.w3.org/2001/XMLSchema" i:type="d4p1:string">0</d2p1:value>  
    </KeyValuePairOfstringanyType>  
    <KeyValuePairOfstringanyType>  
      <d2p1:key>SubErrorCode</d2p1:key>  
      <d2p1:value xmlns:d4p1="http://www.w3.org/2001/XMLSchema" i:type="d4p1:string">-2146233088</d2p1:value>  
    </KeyValuePairOfstringanyType>  
  </ErrorDetails>  
  <Message>custom error message</Message>  
  <Timestamp>2014-09-04T17:43:16.8197965Z</Timestamp>  
  <InnerFault i:nil="true" />  
  <TraceText>  
  
[Microsoft.Crm.ObjectModel: Microsoft.Crm.ObjectModel.SyncWorkflowExecutionPlugin]  
[cf6a25a9-5a34-e411-80b9-00155dd8c20f: ]  
Starting sync workflow 'Name of Entity Scope Business Rule returning Error', Id: c76a25a9-5a34-e411-80b9-00155dd8c20f  
Entering ConditionStep1_step:   
Entering SetMessage_step:   
Sync workflow 'Name of Entity Scope Business Rule returning Error' terminated with error 'custom error message'  
  
</TraceText>  
</OrganizationServiceFault>  
```  
  
 [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Create and edit Business Rules](https://technet.microsoft.com/library/dn531086.aspx).  
  
<a name="BKMK_AdditionalInfo"></a>   
## Additional information about exceptions  
 When an uncaught exception is thrown that contains sensitive information that the user doesn’t have permission to see, the sensitive information in the exception is hidden from the user and a reference number is provided. This reference number refers to the related server event log entry and server trace entry. A system administrator can look up those entries and find more information about the exception.  
  
### See also  
 [Troubleshooting and error handling](troubleshooting-error-handling.md)   
 [Troubleshooting tips](troubleshooting-tips.md)   
 [Web service error codes](web-service-error-codes.md)   
 [Handle exceptions in plug-ins](../handle-exceptions-plugins.md)   
 [.NET Framework Developer Center](https://msdn.microsoft.com/netframework/aa663324.aspx)
