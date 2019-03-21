---
title: "Restrict access to Dynamics 365 for Customer Engagement apps (online) with trusted IP rules | MicrosoftDocs"
ms.custom: 
ms.date: 01/31/2019
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: 45e17aac-7d50-4022-88b2-9dd5d0895b8c
caps.latest.revision: 4
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Restrict access with trusted IP rules

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

You can limit access to Customer Engagement apps to users with   trusted IP addresses to reduce unauthorized access. When trusted IP address restrictions are set in a user’s profile and the user tries to log in from an untrusted IP address, access to Customer Engagement apps is blocked.  
  
 **Requirements**  
  
- A subscription to [Azure Active Directory Premium](https://www.microsoft.com/cloud-platform/azure-active-directory).  
  
- A federated [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] tenant. See [Azure AD conditional access and federated authentication](https://docs.microsoft.com/azure/active-directory/conditional-access/overview#azure-ad-conditional-access-and-federated-authentication).
  
- Federated tenants require that multi-factor authentication (MFA) be enabled.  
  
<a name="BKMK_AdditionalConsiderations"></a>   
## Additional security considerations  
 IP restriction is only enforced during user authentication.  This is done by the [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] Conditional Access capability. Customer Engagement apps sets a session timeout limit to balance protecting user data and the number of times users are prompted for their sign-in credentials. Trusted IP restriction for devices (including laptops) is not applied until the Customer Engagement apps session timeout expires.  
  
 For example, a trusted IP restriction is setup to only allow access to [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps when users are working from a corporate office.  When a [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps user signs in into [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps using their laptop from their office and establishes a [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps session, the user can continue to access [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps after leaving the office until the [!INCLUDE [pn-crm-shortest](../includes/pn-crm-shortest.md)] apps session timeout expires.  This behavior also applies to mobile and offsite connections such as: Dynamics 365 for Customer Engagement apps for phones and tablets, and [!INCLUDE[pn_crm_app_for_outlook_short](../includes/pn-crm-app-for-outlook-short.md)].  
  
<a name="BKMK_CreateSecurityGroup"></a>   
## Create security group (optional)  
 You can restrict access to all Users or groups of users.  It's more efficient to restrict by a group if only a subset of your Azure Active Directory (Azure AD) users are accessing Customer Engagement apps.  
  
1. Sign in to your [Azure portal](https://portal.azure.com).  
  
2. Click **Browse** > **Active Directory**, and then select your Customer Engagement apps directory.  
  
3. Click **Groups** > **Add Group**, and then fill in the settings to create a new group.  
  
   ![Create a security group](media/CreateGroup65HL.png "Create a security group")
  
4. Click the group you created and add members.  
 
   ![Add members to a restricted group](media/RestrictIPGroup65.png "Add members to a restricted group")
  
<a name="BKMK_CreateTrustedIPRule"></a>   
## Create a location based access rule  
 Access restriction is set using Azure Active Directory (AD) Conditional Access. See [Getting started with conditional access to Azure AD](https://azure.microsoft.com/documentation/articles/active-directory-conditional-access-azuread-connected-apps/).  You control Conditional Access through an access rule.  
  
> [!NOTE]
>  Setting Conditional Access is only available with an [!INCLUDE[pn_azure_active_directory](../includes/pn-azure-active-directory.md)] Premium license.  Upgrade your Azure AD to a Premium license in the Microsoft 365 admin center (**<https://admin.microsoft.com>** > **Billing** > **Purchase services**).  
  
1. Sign in to your [Azure portal](https://portal.azure.com).  
  
2. Click **Browse** > **Active Directory**, and then select your Customer Engagement apps directory.  
  
3. Click **Applications**, and then click  the **Dynamics 365 Online** web application.  
 
   ![Select the Dynamics 365 for Customer Engagement apps (online) web app](media/SelectCRMApp65HL.png "Select the Dynamics 365 for Customer Engagement apps (online) web app") 
  
4. Click **Configure**.  
 
   ![Configure Active Directory properties for Dynamics 365 for Customer Engagement apps (online) instance](media/ConfigureAD65HL.png "Configure Active Directory properties for Dynamics 365 for Customer Engagement apps (online) instance")

5. Set the following on the Properties page:  
  
   1. Set **Enable Access Rule** to **On**.  
  
   2. Optional: Set **Apply to** to **Groups**.  
  
   3. Optional: Click **Add Group** to select a group.  
  
   4. Set **Rules** to **Block access when not at work**.  
  
      ![Set rule to Block access when not at work](media/IPRulesProperties65HL.png "Set rule to Block access when not at work")
  
   5. Click **Save** > **OK**.  
  
   6. Click **Click here to define/edit your work network location**.  
  
      ![Define or edit you work network location](media/DefineNetworkLoc85HL.png "Define or edit you work network location")

6. Enter  trusted IP addresses (using [CIDR notation](https://en.wikipedia.org/wiki/Classless_Inter-Domain_Routing)).  
  
   ![Enter trusted IP addresses](media/EnterTrustedIPs75.png "Enter trusted IP addresses")
  
7. Click **Save**.  
  
### See also  
 [How to set Azure Active Directory device-based conditional access policy for access control to Azure Active Directory connected applications](https://azure.microsoft.com/documentation/articles/active-directory-conditional-access-policy-connected-applications/)   
