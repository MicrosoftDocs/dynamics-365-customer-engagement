---
title: "Important information for CRM Online volume license customers | MicrosoftDocs"
ms.custom: 
ms.date: 09/30/2017
ms.reviewer: 
ms.service: crm-online
ms.suite: 
ms.tgt_pltfrm: 
ms.topic: article
applies_to: 
  - Dynamics 365 for Customer Engagement  (online)
  - Dynamics 365 for Customer Engagement  Version 9.x
ms.assetid: cdb4caa6-6999-4e20-bbc3-5a04d2f3a164
caps.latest.revision: 5
author: jimholtz
ms.author: jimholtz
manager: brycho
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - Powerplatform
---
# Important information for CRM Online volume license customers

[!INCLUDE[cc-applies-to-update-9-0-0](../includes/cc_applies_to_update_9_0_0.md)]

Your Dynamics CRM Online plan is being retired. When it's time to renew, you will need to renew using one of the Dynamics 365 for Customer Engagement apps plans. To learn more about your options, see [Important information for CRM Online customers](../admin/important-information-customers.md).  
  
 If you're an existing Dynamics CRM Online customer, you will be notified when your subscription will expire.  At that time, you'll need to start a new subscription with one of the new Customer Engagement apps licenses. You can switch before you receive the expiration notice.  

> [!IMPORTANT]
> It is important that you switch your users from CRM Online licenses to Dynamics 365 for Customer Engagement apps licenses in order to avoid any service disruption.
  
 ![Email: Dynamics 365 for Customer Engagement apps (online) is expiring](../admin/media/expireemail.png "Email: Dynamics 365 for Customer Engagement apps (online) is expiring") 

<a name="BKMK_ReassignLicense"></a>   

## Reassign user licenses  
 You can use the [!INCLUDE[pn_office_365_admin_center](../includes/pn-office-365-admin-center.md)] to reassign licenses for up to 20 users at a time.  
  
> [!TIP]
>  If you have a lot of users, you can optionally use Remote PowerShell to assign user licenses. To learn how, see [Use Office 365 PowerShell to assign licenses to user accounts](https://technet.microsoft.com/library/dn771770.aspx).  
  
1. In the admin center, choose **Users** > **Active users**.  
  
2. Select the boxes next to the names of the users that you want to move to the [!INCLUDE[pn_dyn_365](../includes/pn-crm-shortest.md)] subscriptions.  
  
3. In the **Bulk actions**-pane, choose **Edit product licenses**.  
  
4. Select **Replace existing product license assignments** > **Next**.  
  
5. Toggle the switches to **Off** to remove a license and **On** to add a license to users.  
  
6. When you’re done, choose **Replace** > **Close**.  

## What happens to my data when I switch to a Dynamics 365 for Customer Engagement apps subscription?
Your data, user records, customization, etc., are stored in your tenant and are not tied directly to a specific CRM Online subscription. When you switch to a Dynamics 365 for Customer Engagement apps subscription, the new licenses provide access to your existing CRM organization and will not lead to any loss of data.

## What happens if I do not switch my users to Dynamics 365 for Customer Engagement apps licenses?
If you do not switch your users to a Dynamics 365 for Customer Engagement apps subscription before the term end date, the CRM Online subscription will enter into an expired state for 90 days for most subscriptions, in most countries and regions. At the end of the expired state, the subscription moves into the disabled state, which is 90 days for most subscriptions, in most countries and regions.

Here's what to expect for you and your users if your subscription is disabled.

- Admin access: Admins can still sign in and access the Microsoft 365 admin center, and buy other Microsoft Online Services as needed.

- User access: Your users won't be able to use Dynamics 365 for Customer Engagement, or access customer data. CRM Online applications will eventually move into a read-only, reduced functionality mode and display Unlicensed Product notifications.

### See also  

[Important information for CRM Online customers](important-information-customers.md)
[Switch from Dynamics CRM Online to Dynamics 365 for Customer Engagement apps (online)](switch-dynamics-crm-online-dynamics-365.md)
[Support and billing](billing-support.md)
