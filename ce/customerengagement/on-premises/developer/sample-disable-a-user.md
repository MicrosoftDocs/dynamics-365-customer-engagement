---
title: "Sample: Disable a user (Developer Guide for Dynamics 365 Customer Engagement) | MicrosoftDocs"
ms.custom: 
ms.date: 10/31/2017
ms.reviewer: pehecke
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: samples
applies_to: 
  - Dynamics 365 Customer Engagement (on-premises)
ms.assetid: 082fc88f-a951-41c2-85ae-4b5e69e9917c
caps.latest.revision: 15
author: KumarVivek
ms.author: kvivek
manager: amyla
search.audienceType: 
  - developer

---
# Sample: Disable a user

This sample code is for [!INCLUDE[pn_dynamics_crm_online](../includes/pn-dynamics-crm-online.md)]. Download the complete sample from [Sample: Work with Users and Roles](https://github.com/microsoft/Dynamics365-Apps-Samples/tree/master/samples-from-msdn/UsersAndRoles).   
  
## Requirements  
[!INCLUDE[sdk_SeeConnectionHelper](../includes/sdk-seeconnectionhelper.md)]
  
## Demonstrates  
 This sample shows how to create a user in an [!INCLUDE[pn_Active_Directory](../includes/pn-active-directory.md)] environment using the <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest> message. A snippet showing just the key sections of the sample is shown first, followed by the [complete sample code](sample-create-on-premises-user.md#complete_sample). Note that this sample can only be run in an on-premises environment because it creates a user. However, the portion of the sample that demonstrates disabling the user will work for all environments.  
  
 [!INCLUDE[cc_sdk_onpremises_note](../includes/cc-sdk-onpremises-note.md)] 
 
## Example  
 [!code-csharp[UsersAndRoles#DisableOrEnableUser1](../snippets/csharp/CRMV8/usersandroles/cs/disableorenableuser1.cs#disableorenableuser1)]  
  
<a name="complete_sample"></a>   
### Complete sample code  
 [!code-csharp[UsersAndRoles#DisableOrEnableUser](../snippets/csharp/CRMV8/usersandroles/cs/disableorenableuser.cs#disableorenableuser)]  
  
### See also  
 [User and Team Entities](user-team-entities.md)   
 <xref:Microsoft.Crm.Sdk.Messages.SetStateRequest>   
    


[!INCLUDE[footer-include](../../../includes/footer-banner.md)]