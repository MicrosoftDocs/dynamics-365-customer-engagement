---
title: "Helper code: SystemUserProvider class (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "The SystemUserProvider class demonstrates how to programmatically create additional users in Active Directory andDynamics 365 (online) Customer Engagement"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
helpviewer_keywords: 
  - "creating additional users by using Active Directory in CRM"
  - "SystemUserProvider class, helper code samples"
  - "sample for creating additional users by using Active Directory in CRM, SystemUserProvider class"
  - "adding more users by using Active Directory in CRM sample, SystemUserProvider class"
  - "SystemUserProvider class, creating additional users by using Active Directory in CRM"
  - "helper code samples, SystemUserProvider class"
ms.assetid: 4a4da7b8-ca42-4f03-9a27-83d487d38ace
caps.latest.revision: 27
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Helper code: SystemUserProvider class

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

The file is present in code samples' folder that you download.
 
 Path: `download-directory>\<sample name>\C#\SystemUserProvider.cs`.
 
 For example, if you download the **Work with visualizations and dashboards** sample to D drive, you can find the sample in the following folder path.

 Path: `D:\Work with visualizations and dashboards\SystemUserProvider.cs`
  
## Requirements  
 The logged on system user must have system administration privileges for this sample code to create the new user accounts. [!INCLUDE[sdk_SeeConnectionHelper](../../includes/sdk-seeconnectionhelper.md)]  
  
## Demonstrates  
 The **SystemUserProvider** class demonstrates how to programmatically create additional users in [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] and[!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)] Customer Engagement.  
  
 Several SDK samples require additional (fictitious) system users to exist in [!INCLUDE[pn_dynamics_crm_online](../../includes/pn-dynamics-crm-online.md)], other than the logged on user, for the sample to perform its intended task. These samples use the **SystemUserProvider** class methods to create these additional required users. Since it currently is not possible to programmatically create a new [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] user, when running against a [!INCLUDE[pn_CRM_Online](../../includes/pn-crm-online.md)] server, the code just prints the required user information to the console. You can then manually add and invite those users if desired.  
  
## Example  
 [!code-csharp[HelperCode#SystemUserProvider](../../snippets/csharp/CRMV8/helpercode/cs/systemuserprovider.cs#systemuserprovider)]
  
### See also  
 [Use the Sample and Helper Code](use-sample-helper-code.md)   
 [Helper Code: Enumerations for Option Sets](helper-code-enumerations-option-sets.md)   
 <xref:Microsoft.Crm.Sdk.Messages.AssociateEntitiesRequest>   
 <xref:Microsoft.Xrm.Sdk.Messages.RetrieveMultipleRequest>