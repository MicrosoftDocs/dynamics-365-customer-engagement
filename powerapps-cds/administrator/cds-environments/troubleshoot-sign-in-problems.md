---
title: Troubleshoot sign-in problems | Microsoft Docs
description: In this quickstart, you learn how to download a list of apps created in your environments
services: 'powerapps'
suite: powerapps
documentationcenter: na
author: jimholtz
manager: kfile
editor: ''
tags: ''

ms.service: powerapps
ms.devlang: na
ms.topic: article
ms.tgt_pltfrm: na
ms.workload: na
ms.date: 03/21/2018
ms.author: jimholtz

---
# Troubleshoot sign-in problems

[!INCLUDE[cc-applies-to-update-9-0-0](../../includes/cc_applies_to_update_9_0_0.md)]<br/>[!INCLUDE [cc_applies_to_update_8_2_0](../../includes/cc_applies_to_update_8_2_0.md)]

Having trouble signing in to [!INCLUDE[pn_CRM_online](../../includes/pn-crm-online.md)] or another [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] service, such as [!INCLUDE[pn_netbreeze_long](../../includes/pn-social-engagement-long.md)]? Here’s what you need to know about passwords, signing in, and common error messages.  
  
> [!IMPORTANT]
>  If you’re an administrator, make sure to check the [Service Health Dashboard](https://portal.office.com/ServiceStatus/ServiceStatus.aspx) for maintenance issues.  
  
## Password issues  
  
### If you’re an administrator  
 If you forget your administrator password, you can reset it by going to the [sign-in page](https://portal.office.com), and choosing **Can’t access your account?** at the bottom of the page.  
  
 ![Reset your Dynamics 365 Online password](../admin/media/reset-crm-online-password.png "Reset your Dynamics 365 Online password")  
  
> [!TIP]
>  To enable your users to be able to reset their passwords themselves, you’ll need to purchase an [!INCLUDE[pn_azure_active_directory](../../includes/pn-azure-active-directory.md)] subscription and configure it for password self-service. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Self-service password reset in Azure AD: how to enable, configure, and test self-service password reset](https://msdn.microsoft.com/library/azure/dn683881.aspx)  
  
 To reset user passwords, you use the [!INCLUDE[pn_office_365_admin_center](../../includes/pn-office-365-admin-center.md)]. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Reset a user's password](https://support.office.com/article/Reset-a-users-password-7a5d073b-7fae-4aa5-8f96-9ecd041aba9c)  
  
### If you’re not an administrator  
 If you’re not an administrator, and you forgot your password, you’ll need to contact your administrator and ask for a password reset. Once your administrator resets your password, you’ll receive an email with instructions on how to sign in and enter a new password. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md)  
  
## Signing in  
  
<a name="BKMK_forenduser"></a>   
### For admins and end users: Sign in at https://portal.office.com  
 For admins and end users, when you sign in to https://portal.office.com, you will go to the [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] Welcome page. The tiles that appear on the Welcome page depend on what licenses you have. For example, if you have licenses for [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] and [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)], you'll see tiles for [!INCLUDE[pn_MS_Office](../../includes/pn-ms-office.md)] apps like [!INCLUDE[pn_ms_Word_short](../../includes/pn-ms-word-short.md)], [!INCLUDE[pn_onedrive](../../includes/pn-onedrive.md)], and [!INCLUDE[pn_SharePoint_short](../../includes/pn-sharepoint-short.md)], as well as a tile for [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)].  
  
 ![Office 365 welcome page](../admin/media/office-365-welcome-page.png "Office 365 welcome page")  
  
 Click the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] tile to go to the [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] Home page. See [For admins and end users: Select a Dynamics 365 app from the new app switcher](quickly-navigate-office-365-app-launcher.md).

 If you're a [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] system administrator, you'll see an **Admin** tile. Click this tile to get to the [!INCLUDE[pn_office_365_admin_center](../../includes/pn-office-365-admin-center.md)], where you can see your service health, manage users, manage licenses, and more for all the online services associated with your account.  
  
 ![Admin tile on the Office 365 welcome page](../admin/media/admin-tile-office-365-welcome-page.png "Admin tile on the Office 365 welcome page")  
  
 From there, you can get to the [!INCLUDE[pn_dyn_365_admin_center](../../includes/pn-dyn-365-admin-center.md)]. Click **Admin centers** > **Dynamics 365**.  
  
 ![Dynamics 365 option in the Admin center drop-down list](../admin/media/dynamics-365-option-admin-center.png "Dynamics 365 option in the Admin center drop-down list")  
  
 For other ways to access Dynamics and [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] apps, see [Quickly navigate with the Office 365 app launcher and the Dynamics 365 home page](quickly-navigate-office-365-app-launcher.md).
 
  
<a name="BKMK_DirectHomePage"></a>   
### For admins and end users: Sign in to the Dynamics 365 home page  
 We have a new [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] home page for you to use  to manage and open [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] apps. You can sign in to this page directly using your [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] (or Active Directory) credentials with this URL: https://home.dynamics.com  
  
 For information on the [!INCLUDE[pn_dyn_365](../../includes/pn-dyn-365.md)] home page, see: [For admins and end users: Introducing the Dynamics 365 home page](quickly-navigate-office-365-app-launcher.md#BKMK_IntroD365HomePage).  
  
### If you’re an end user  
 You can sign in directly to [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] or [!INCLUDE[pn_netbreeze_long](../../includes/pn-social-engagement-long.md)]. You can also sign in at https:/portal.office.com.  
  
#### Sign in directly to Dynamics 365 (online)  
 Your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] administrator provides the direct [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)] URL in an email invitation. This URL will be in the following format:  https://\<yourorganization>.crm.dynamics.com. For example, enter https://contoso.crm.dynamics.com. If you can’t find the email that contains the URL, contact your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] administrator. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Find your Dynamics 365 administrator or support person](../basics/find-administrator-support.md)  
  
> [!NOTE]
>  If you’re in a region other than North America, substitute “*crm*” in the URL with:  
>   
> -   .crm2 for South America (LATAM/SAM)  
> -   .crm3 for Canada (CAN)  
> -   .crm4 for Europe, Middle East, Africa (EMEA)  
> -   .crm5 for Asia Pacific (APAC)  
> -   .crm6 for Oceania (OCE)  
> -   .crm7 for Japan (JPN)  
> -   .crm8 for India (IND)  
> -   .crm9 for United States of America Government  
  
 After entering your URL, you’ll be prompted for your user name. Your user name will be in one of the following formats:  
  
-   username@contoso.onmicrosoft.com (standard [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] domain)  
  
-   username@contoso.com (custom domain)  
  
**What if I’m still using a [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] to sign in to [!INCLUDE[pn_crm_online_shortest](../../includes/pn-crm-online-shortest.md)]?**  
  
Use the email address provided by your [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] administrator (sent in an email invitation). Verify that you’re using the same [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)] email address that the email invitation was sent to. Note that you can’t sign in to [!INCLUDE[pn_netbreeze_long](../../includes/pn-social-engagement-long.md)] with a [!INCLUDE[pn_Windows_Live_ID](../../includes/pn-windows-live-id.md)]. [Troubleshoot problems with your Microsoft account user name or password.](http://go.microsoft.com/fwlink/p/?LinkId=225672)  
  
#### Sign in directly to Microsoft Social Engagement  
 Your administrator provides the direct URL for [!INCLUDE[pn_netbreeze_long](../../includes/pn-social-engagement-long.md)] in an email invitation. This URL will be in the following format: https://listening.microsoft.com/app/\<appID>/. If you can’t find the URL, contact your administrator.  
  
 After entering your URL, you’ll be prompted for your user name. Your user name will be in one of the following formats:  
  
-   username@contoso.onmicrosoft.com (standard [!INCLUDE[pn_Office_365](../../includes/pn-office-365.md)] domain)  
  
-   username@contoso.com (custom domain)  
  
## Common error messages  
  
### I receive this license error: “The selected user or the user trying to log on has not been assigned a security role, and does not have sufficient privileges for this action”  
 This error must be fixed by someone that has permissions to add security roles to users in [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)], such as your system administrator. To learn how to add security roles, see [Security roles and privileges](security-roles-privileges.md).  
  
### When I try to sign in, [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)] continues to redirect to another web page and gets into a loop until I choose the [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)] window.  
 To avoid this error, add the URLs used for [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] to trusted sites in [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)]:  
  
1.  In [!INCLUDE[pn_Internet_Explorer](../../includes/pn-internet-explorer.md)], on the **Tools** menu, select **Internet Options**.  
  
2.  On the **Security** tab, in the **Select a zone to view or change security settings** section, click or tap **Trusted sites**.  
  
3.  Click or tap **Sites**.  
  
4.  In the **Trusted sites** dialog box, type the following URLs in the **Add this website to the zone** text box:  
  
    -   http://*.dynamics.com  
  
    -   http://*.live.com  
  
    After you add each URL, click or tap the **Add** button.  
  
5.  If you receive a dialog box that states **Sites added to this zone must use the https:// prefix**, clear the **Require server verification (https:) for all sites in this zone** check box.  
  
6.  Click or tap **Close**, and then click or tap **OK**.  
  
### Why do I have to sign in again? Can I change the amount of time I'm signed in?  
 [!INCLUDE[pn_microsoftcrm](../../includes/pn-microsoftcrm.md)] keeps you signed in for 8 hours. When you've been signed in for 7 hours and 40 minutes, a message will appear warning that your session is about to expire, and you then have 20 minutes to respond. Click or tap **OK**, sign in again, and then click the back button on your browser to return to the area of [!INCLUDE[pn_crm_shortest](../../includes/pn-crm-shortest.md)] in which you were working. You can’t change the amount of time you’re signed in.  
  
### See also  
 [Sign in to Dynamics and Office 365 apps](sign-in-office-365-apps.md)    
 [Contact technical support](contact-technical-support.md) 
