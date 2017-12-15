---
title: "Troubleshooting tips (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "This topic contains tips to diagnose and fix certain common issues that may arise when developing Dynamics 365 SDK–based applications"
ms.custom: ""
ms.date: 12/15/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: 79667e12-19eb-4942-bb44-3212a7e42899
caps.latest.revision: 40
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Troubleshooting tips

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The following information is provided as an aid in diagnosing certain common issues that may arise when developing applications using the .NET SDK assemblies. More content will be added to this topic as time goes on.  
  
 For more information about enabling tracing in an on-premises [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement server, see [Monitor and troubleshooting Microsoft Dynamics CRM](https://technet.microsoft.com/library/hh699694.aspx).  
  
## Handle the MessageSecurityException exception when you use the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] web services
  
 When you use the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] APIs to connect to the [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] organization or discovery services you could receive the following exception:  
  
```ms-dos  
Unhandled Exception: System.ServiceModel.Security.MessageSecurityException: An unsecured or incorrectly secured fault was received from the other party. See the inner FaultException for the fault code and detail.  
```  
  
 To fix this, you can try deleting the device registration folder named `LiveDeviceID` in your profile folder `C:\Users\<username>`. Then, try to connect again.  
  
## Exceptions that can occur when running CrmSvcUtil  

 When you run the CrmSvcUtil.exe tool to generate early-bound entity types, you might receive an exception with the following message.  
  
```ms-dos  
The type initializer for Microsoft.Xrm.Client.CodeGeneration.CodeCustomization threw an exception.  
```  
  
 This error can be caused if the build version of the CrmSvcUtil tool and `Microsoft.Xrm.Client.CodeGeneration.dll` assembly aren’t the same. When you develop applications using the .NET SDK assemblies, always use the CrmSvcUtil tool and assemblies that are provided in the same version of the NuGet package.  
  
### See also  
 [Troubleshooting and Error Handling](troubleshooting-error-handling.md)   
 [Web Service Error Codes](web-service-error-codes.md)
