---
title: "Impersonate another user (Developer Guide for Dynamics 365 Customer Engagement)| MicrosoftDocs"
description: "Learn how to impersonate another user using Web API. You can do that by adding a request header named MSCRMCallerID with a GUID value equal to the impersonated user’s systemuserid before sending the request to the web service"
ms.custom: ""
ms.date: 10/31/2017
ms.reviewer: ""
ms.service: "crm-online"
ms.suite: ""
ms.tgt_pltfrm: ""
ms.topic: "article"
applies_to: 
  - "Dynamics 365 (online)"
ms.assetid: fc54b5d4-00d7-4833-be95-3c66a920a84d
caps.latest.revision: 28
author: "JimDaly"
ms.author: "jdaly"
manager: "amyla"
---
# Impersonate another user

[!INCLUDE[](../../includes/cc_applies_to_update_9_0_0.md)]

Impersonation is used to execute business logic (code) on behalf of another [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Customer Engagement user to provide a desired feature or service using the appropriate role and object-based security of that impersonated user. This is necessary because the [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] Web services can be called by various clients and services on behalf of a [!INCLUDE[pn_dynamics_crm](../../includes/pn-dynamics-crm.md)] user, for example, in a workflow or custom ISV solution. Impersonation involves two different user accounts: one user account (A) is used when executing code to perform some task on behalf of another user (B).  

## Required privileges  
 User account (A) needs the privilege `prvActOnBehalfOfAnotherUser`, which is included in the **Delegate** security role.  

 The actual set of privileges that is used to modify data is the intersection of the privileges that the **Delegate** role user possesses with that of the user that is being impersonated. In other words, user A is allowed to do something if and only if user A and the impersonated user (B) have the privilege necessary for the action.  

## Impersonate a user  
 To impersonate a user, set the <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy.CallerId> property on an instance of <xref:Microsoft.Xrm.Sdk.Client.OrganizationServiceProxy> before calling the service’s Web methods.  

## Deployment specific options  
 Impersonation using a user account in the `PrivUserGroup` in [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] is no longer supported in the on-premises environment.  In our ongoing design enhancement of the security protocol, we developed a better and more secure impersonation method.  The new method calls for using a [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] user and a [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] security role.  With this method, the user’s privileges are managed through [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] and activities are logged for the user. Please see the following table for details.  


|           Deployment Type            |                                                                                                                                                                                                                                    Deployment Type  Strategy                                                                                                                                                                                                                                     |
|--------------------------------------|--------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
|                Online                | -   Use the special  *application user* described in [Build web applications using Server-to-Server (S2S) authentication](../build-web-applications-server-server-s2s-authentication.md) to control the privileges that the [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] user has access to.<br />-   Grant the application user a security role that includes privileges for the tasks this user will perform on behalf of other users and the `prvActOnBehalfOfAnotherUser` privilege. |
| On-premises<br /> or<br />IFD/Claims |                                                                                                        Create a new [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] user with a security role which includes the `prvActOnBehalfOfAnotherUser` privilege. Within this security role, also include privileges for the tasks this user account will perform on behalf of other users.                                                                                                         |

### See also  
 [Authenticate Users with Dynamics 365 Web Services](../authenticate-users.md)   
 [Implement Single Sign-on from an ASPX Webpage or IFRAME](../implement-single-sign-aspx-webpage-iframe.md)     
 [How Role-Based Security Can Be Used to Control Access to Entities In Dynamics 365](../security-dev/how-role-based-security-control-access-entities.md)   
 [Sample: Impersonation using the ActOnBehalfOf privilege](sample-impersonate-actonbehalfof-privilege.md)
