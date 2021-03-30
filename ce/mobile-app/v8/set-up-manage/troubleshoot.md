---
title: "Troubleshooting Dynamics 365 for phones and Dynamics 365 for tablets | MicrosoftDocs"
ms.custom:
ms.date: 01/22/2018
ms.reviewer:
ms.service: crm-online
ms.suite:
ms.tgt_pltfrm:
ms.topic: get-started-article
applies_to: Dynamics 365 apps
ms.assetid: 613288f5-1c9a-420e-ba06-8d1b1f6675b0
caps.latest.revision: 141
ms.author: mkaur
author: mduelae
manager: kvivek
search.audienceType:
  - admin
  - customizer
  - enduser
search.app:
  - D365CE
  - D365Sales
---
# Troubleshooting and things to know

The following are known issues with [!INCLUDE[pn_moca_full](../../../includes/pn-moca-full.md)].

## Important considerations  
 Before you begin to configure [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)], it’s important to review the requirements:  
  
- **Understand what operating systems, devices, and languages are supported**. Review the requirements in [Support for Dynamics 365 for tablets](support.md).  
- Be aware that **Internet-facing deployment (IFD) is required if you’re using Dynamics 365 apps (on-premises)**. The system administrator must configure claims-based authentication before users can access Dynamics 365 apps data with Dynamics 365 for tablets. If you have your Dynamics 365 apps website available over the Internet but it is not using the Dynamics 365 apps IFD configuration, **it is not supported**. To verify that your on-premises deployment is configured for IFD, open Microsoft Dynamics 365 apps Deployment Manager on your Dynamics 365 apps server. The **Authentication Summary** section should show that both claims-based authentication and Internet-facing deployment are enabled. More information: [Configure IFD for Microsoft Dynamics 365 apps](/previous-versions/dynamicscrm-2016/deployment-administrators-guide/dn609803(v=crm.8)) 

  ![Dynamics 365 apps IFD settings](../../media/crm-ua-moca-claims.png "Dynamics 365 apps IFD settings")

- [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] uses a security privilege, **[!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] for mobile**, to provide access to [!INCLUDE[pn_Mobile_Express_short](../../../includes/pn-mobile-express-short.md)] and [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]. The privilege is pre-configured for Sales roles, but not other security roles, so you may want to add to other roles for your teams.

<a name="BKMK_PotentialIssues"></a>

## Potential issues and resolutions
<!--Use the error message that appears in the app to identify a potential fix listed in this topic. Be aware that an error may have multiple causes. To narrow down the possibilities, system administrators can use tracing to capture details for analysis. [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Enable tracing for Dynamics 365 for tablets](../Topic/Monitor%20and%20troubleshoot%20Microsoft%20Dynamics%20365.md#BKMK_MoCA_tracing)  -->

<a name="BKMK_Errors"></a>

### Errors and connection issues

#### Troubleshoot error code 800c0019 on Windows Phones

If you get error code 800c0019 when you try to sign in to your [!INCLUDE[cc_Microsoft](../../../includes/cc-microsoft.md)] account while using the [!INCLUDE[pn_Mobile_Express_long](../../../includes/pn-mobile-express-long.md)] or [!INCLUDE[pn_crm_for_phones_express](../../../includes/pn-crm-for-phones-express.md)] apps, chances are that you have the wrong date and time settings on your [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)] phone. This can occur after updating your [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)] phone, removing and replacing the battery, or after a time change.

 In most cases, your phone’s date and time is set automatically by your mobile operator. If it’s not, you need to set it manually so you can sign in to your [!INCLUDE[cc_Microsoft](../../../includes/cc-microsoft.md)] account successfully. Here’s how:

1.  On **Start**, flick left to the **App** list and tap **Settings**.

2.  Tap **Date+time**.

3.  Turn off **Set automatically**.

4.  Set the correct values for **Time zone**, **Date**, and **Time**.

#### Troubleshoot a Windows app start-up error

If you receive this error:

 **Additional steps may be needed to configure [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] for this organization. Please contact your system administrator**.

##### If you’re using a computer or tablet

|             |                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                                   |
|-------------|-------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
| **Users:**  |                                                                                                                                                                                                                                                                     Notify your [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] administrator that you received this error.                                                                                                                                                                                                                                                                     |
| **Admins:** | To enable the [!INCLUDE[pn_microsoft_dynamics_crm_for_windows_81](../../../includes/pn-microsoft-dynamics-crm-for-windows-81.md)] app for on-premises [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] deployments, you need to make some configuration changes. [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Set up Dynamics 365 for phones and tablets](set-up.md) **Important:** [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] on-premises deployments require Windows 10 and the [Dynamics 365 apps for Windows app built for Windows 10](https://go.microsoft.com/fwlink/p/?LinkID=799909). |
  
##### If you’re using a Windows phone  
 You received this error because you’re trying to connect to an on-premises deployment of [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)], which is  not supported for your version on Windows Phones. Windows Phone connection to [!INCLUDE[pn_crm_2016](../../../includes/pn-crm-2016.md)] on-premises requires the [Dynamics 365 apps for Windows app built for Windows 10](https://go.microsoft.com/fwlink/p/?LinkID=799909). [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Support for Dynamics 365 for phones and tablets](support.md)  
  

#### Error message: “This record is unavailable.”  
 If this message appears when a user starts the mobile app, taps the **Home** button, or selects **Dashboards** from the menu, the user likely doesn’t have access to the expected dashboards.  
  
 If you’re an admin, you can avoid users getting this error by making sure all mobile users have access to the sales dashboard:  
  
1. In the web app, go to **Settings > Customizations > Customize the System**.  
  
2. Click **Dashboards**.  
  
3. Select **Sales Dashboard**.  
  
4. Click **Enable Security Roles**.  
  
5. Select **Display to everyone** and then click **OK**. If you prefer to display only to select security roles, be sure to select your user’s security role.  
  
6. Click **Publish**.  
  
7. Have your user close and open the mobile app so your dashboard changes will download.  
  
   If you’re an end user and you’re seeing this message on your home page, you can choose a different dashboard and set it as your home page:  
  
8. From the mobile app, tap the menu and then tap **Dashboards**.  
  
9. On the command bar, tap **Select Dashboard** and then select the dashboard you would like to use as your home page.  
  
10. On the command bar, tap **Set as Home**.  
  
    If you’re an end user and you’re seeing this message on the dashboards page, you can create a personal dashboard through the web app and enable it for mobile:  
  
11. In the web app, go to **Sales > Dashboards**.  
  
12. Click **New**.  
  
13. Click **Properties**.  
  
14. Enter a name for your dashboard and select **Enable for mobile**.  
  
15. Add the components you want on your dashboard and click **Save**.  
  
16. In the mobile app, follow the previous procedure to select your new dashboard and set it as your home page.  
  
#### Error message: “Your server is not available or does not support this application.”  
 **Cause 1**: The [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] server is down. Verify that the server is on and connected to your network.  
  
 **Sample Trace Message for Cause 1**:  
  
 `“Dynamics CRM [Error] | Connection error: 404”`  
  
 **Cause 2**: Your Dynamics 365 apps  version is not supported. See [What's supported](support.md) for version support information.  
  
 **Cause 4**: This error can also occur if you enter an invalid URL. Make sure the same URL you have provided works to access [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] in your browser on your device.  
  
 **Sample Trace Messages for Cause 4**:  
  
 `“XMLHttpRequest: Network Error 0x2ee7, Could not complete the operation due to error 00002ee7.”`   
 `“Dynamics CRM [Error] | Connection error: 0”`  
  
#### Error message: "You haven't been authorized to use this app. Check with your system administrator to update your settings."  
 **Cause 1**: Verify that your [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] security role includes the **Use [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]** privilege. See "Required privileges" in [Set up Dynamics 365 for phones and Dynamics 365 for tablets](set-up.md).  
  
 **Cause 3**: This error can occur if you have a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] organization and your user has not been assigned a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] license. If you add a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] subscription to an existing [!INCLUDE[pn_MS_Office_365](../../../includes/pn-ms-office-365.md)] tenant, your user may not have a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] license assigned. If the user has the Global Administrator or Service Administrator role in the [Microsoft Online Service Portal](https://portal.microsoftonline.com/), you’re able to sign in to the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] web application to perform certain administrative actions, but you can’t perform end user tasks, such as creating records (for example, accounts, contacts, and leads) or configuring [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]. When you sign in to the web application, you may notice that not all areas appear within the navigation (for example, Sales and Marketing are missing):  
  
 ![Sales and Marketing tabs missing](../../../admin/media/mobile-app-sales-marketing-missing.png "Sales and Marketing tabs missing")  
  
 Access the **Users and Groups** section within the [Microsoft Online Service Portal](https://portal.microsoftonline.com/) and verify you have a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] license assigned to your user record.  
  
 ![Terry Adam's Dynamics 365 apps License](../../../admin/media/mobile-app-social-engagement-icense.png "Terry Adam's Dynamics 365 apps License")  
  
#### Error message: "You need an internet connection to use this app. Reconnect and try again."  
 **Cause 1**: This error can occur if you do not have an Internet connection. Verify you are connected to the Internet and can access the same URL in your web browser.  
  
 **Cause 2**: Check if you are using a preview build of Windows 8.1. So far this issue has only been reported with the preview version of Windows 8.1.  
  
#### Error message: "Sorry, something went wrong while initializing the app. Please try again, or restart the app."  
 **Cause 1**: Permissions might not be set properly. See "Required privileges" in [Set up Dynamics 365 for phones and Dynamics 365 for tablets](set-up.md).  
  
 **Cause 2**: See the following KB article:  
  
 An error occurs in the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] app for users in child business units. For more information, see [Sorry, something went wrong while initializing the app](https://support.microsoft.com/kb/2899860).  
  
 **Sample Trace Message for Cause 2**:  
  
 `Error Message:System.NullReferenceException: Object reference not set to an instance of an object.`   
 `Microsoft.Crm.Application.WebServices.ApplicationMetadataService.<>c__DisplayClass30.<UserRolesChanged>b__2d(Entity role)`   
  `at System.Linq.Enumerable.Any[TSource](IEnumerable`1 source, Func`2 predicate)`   
  `at Microsoft.Crm.Application.WebServices.ApplicationMetadataService.UserRolesChanged(Guid[] clientUserRoles, DateTime syncTime, ExecutionContext context)`   
 `at Microsoft.Crm.Application.WebServices.ApplicationMetadataService.RetrieveUserContext(UserContextRetrieveRequest userContextRetrieveRequest)`  
  
 **Cause 3**: This can occur if the download of the metadata failed. The next attempt to connect will fully regenerate the metadata and successfully connect. Microsoft is aware of an issue where metadata may fail to download due to a timeout and plans to address this issue in a future update.  
  
 **Sample Trace Messages for Cause 3**:  
  
 `“Error occurred during complete refresh of Application/Entity/Attribute metadata”`   
 `“XMLHttpRequest: Network Error 0x2ef3, Could not complete the operation due to error 00002ef3.”`  
  
#### Error message: “The language installed on your company’s system isn’t available on the app. Please contact your system administrator to set up a supported language.”  
 **Cause**: This error will occur if one of the supported languages is not enabled in [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)]. For more information on the supported languages, see [Dynamics 365 for tablets: Set up and use](../../../customerengagement/on-premises/basics/basics-guide.md) and expand **What you need to use Dynamics 365 for tablets** and **Supported Languages**.  
  
#### Error message: “The process assigned to this record is unavailable or has been deleted.”  
 If you receive this message for a record which has a non-deleted process assigned to it, you should manually synchronize [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] with your [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] data. Close the [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] app, reopen, and then choose to download the latest customizations. This procedure forces [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] to check for updated customizations. Recently viewed data while you were connected is cached and synched. Record data like Accounts or Contacts are not synched. You can’t choose which data synchronizes to the device like you can with [!INCLUDE[pn_microsoft_dynamics_crm_for_outlook](../../../includes/pn-microsoft-dynamics-crm-for-outlook.md)].  
  
#### Error message: “This operation failed because you’re offline. Reconnect and try again.”  
 This error may occur for the following scenarios when you are using a [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)]8 device and you have a [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] organization that uses [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)] (formerly named Live ID). This issue doesn’t occur for organizations provisioned through [!INCLUDE[pn_Office_365](../../../includes/pn-office-365.md)].  
  
 **Cause 1**: You are automatically authenticated as a different [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)] that is not a member of the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization. This may happen if you sign into your [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)] device and your domain account is connected to a [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)]. For example: you sign in to your device as *\<userid>*@contoso.com (your domain account) and that account is connected to *\<userid>*@live.com (a [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)]). If your connected account (for example,  *\<userid>*@live.com) is not a member of the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization, you will encounter this error. In this scenario, the error occurs after providing your URL, but you are never prompted for credentials. When you connect your domain account to a [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)], that account will be used to automatically sign in to apps and services that use [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)] for authentication. If you’re using a [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)] device, use the steps listed here to check if your domain account is connected to a [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)]. If you’re using a [!INCLUDE[pn_Windows_RT](../../../includes/pn-windows-rt.md)] device, see the **Windows RT** section.  
  
 **Windows 8**  
  
1. Swipe from the right side of the screen to access the charms bar and then tap **Settings**.  
  
   ![Windows 8 charms bar](../../../admin/media/mobile-app-bar.png "Windows 8 charms bar")  
  
2. Tap **Change PC settings**.  
  
   ![Change PC settings](../../../admin/media/mobile-app-change-pc-settngs.png "Change PC settings")  
  
3. Tap **Users**.  
  
4. Check to see if under the **Your Account** section it says “This domain account is connected to *\<Your Microsoft account>*”  
  
   ![Your Account settings](../../../admin/media/mobile-app-your-account.png "Your Account settings")  
  
   **Windows RT**  
  
   If you are using a [!INCLUDE[pn_Windows_RT](../../../includes/pn-windows-rt.md)] device and need to authenticate as a [!INCLUDE[pn_Windows_Live_ID](../../../includes/pn-windows-live-id.md)] that is different than the one you use to log on to your device, you must create another account and switch to that account when using the app. For example: you currently sign in to your [!INCLUDE[pn_Windows_RT](../../../includes/pn-windows-rt.md)] device as *\<userid>*@live.com, but want to access your [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization via the tablet app as *\<userid>*@outlook.com. For more information on how to create a new account on your device, see [Video: Create a user account](https://go.microsoft.com/fwlink/p/?LinkId=513273).  
  
   **Sample Trace Message for Cause 1**:  
  
   `The app couldn’t navigate to https://port.crm.dynamics.com/portal/notification/notification.aspx?lc=1033&organizationid=<OrganizationId> because of this error: FORBIDFRAMING.`  
  
   **Cause 2**: This error may occur if you previously authenticated to the app as a different Microsoft account and chose the option “Keep me signed in”. Even after uninstalling and reinstalling the app, the token for the previous credentials is still stored on your device. If you are trying to connect as a different user, you will need to remove the token. To completely clear the app, after you uninstall the app, you must clear the Indexed DB folder (Drive:\Users\\%USERNAME%\AppData\Local\Microsoft\Internet Explorer\Indexed DB). You may have to sign in as a different user and use the command prompt as an administrator to clear the Indexed DB folder. That is because some files in this folder can be held by the Host Process for Windows Tasks. Once the token is successfully removed, you should see the sign-in page after you enter your URL in the app.  
  
   ![Sign&#45;in page](../../../admin/media/mobile-app-signin-page.png "Sign-in page")  
  
   The same error as Cause 1 may be found in the traces.  
  
   **Cause 3**: You have not accepted your invitation to the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization. If you attempt to access the same URL through your browser, you see a notification that you are invited to the organization but need to accept the invitation. Once you accept the invitation, you are able to configure the app successfully.  
  
   **Sample Trace Message for Cause 3**:  
  
   `The app couldn’t navigate to https://port.crm.dynamics.com/portal/response/Response.aspx?token=KFES-CK5C-NL8R-X1U0&expiration=635211904207200000&cs=Lkya6zs9EeOtJXjjtRc6AeZa5xqt94YAppfqrXFgZa5slinq2iaabTmwfX0AR4HLGvz&cb=invite&cbcxt=invite&wlid=<username>%40live.com&lc=1033 because of this error: FORBIDFRAMING.`  
  
   For each of the causes listed previously, you may also see the following event logged in the traces:  
  
   `“Authentication: Failed - cookie setup”`  
  
   **Cause 4**: If you connect to a [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization on an Android device, this error can occur if the certificate from the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] website or the federated server, such as AD FS, is not trusted by the device. To avoid this scenario, make sure to use a publicly trusted certificate or add the Certificate Authority certificate to the device. For more information, see KB article: [While configuring Dynamics CRM for phones and tablets, you receive an error message](https://support.microsoft.com/kb/2899983).  
  
#### Error message, [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)]: “We’re sorry. Your server is not available or does not support this application”  
 Users must update to the latest version of the [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] application prior to updating to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)]. On the [Apple App store](https://go.microsoft.com/fwlink/p/?LinkID=524762), the version the users need is 1.1. On the [Good Dynamics Marketplace](https://go.microsoft.com/fwlink/p/?LinkId=524809) or (Good Control Console), the version needed is listed as 1.1.0.  
  
 Users who have not updated their app prior to connecting to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)], will likely see the following error approximately 2 minutes after connecting to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)].  
  
 Error: We’re sorry. Your server is not available or does not support this application.  
  
 To fix this error, the user must uninstall and reinstall the [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] app using the version listed above.  
  
#### Event 10001 messages appear in the Event Log when you run [!INCLUDE[pn_crm_for_windows_8](../../../includes/pn-crm-for-windows-8.md)]  
 The following event may be recorded multiple times to the Event Log, when **Show Analytic and Debug Logs** is enabled, on the device where [!INCLUDE[pn_crm_for_windows_8](../../../includes/pn-crm-for-windows-8.md)] is running. Notice that, by default, **Show Analytic and Debug Logs** is disabled in [!INCLUDE[pn_Event_Viewer](../../../includes/pn-event-viewer.md)] and these messages won’t be recorded. [!INCLUDE[proc_more_information](../../../includes/proc-more-information.md)] [Enable Analytic and Debug Logs](/previous-versions/windows/it-pro/windows-server-2008-R2-and-2008/cc749492(v=ws.11))  
  
- Event Id: 10001  
  
- Message: `SEC7131 : Security of a sandboxed iframe is potentially compromised by allowing script and same origin access.`  
  
  Verify the source of the messages. If the source is [!INCLUDE[pn_microsoftcrm_server](../../../includes/pn-microsoftcrm-server.md)], these events don’t pose a security threat and can be ignored.  
  
#### By design: “—d” added to URL  
 **For [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] users**  
  
 To improve the reliability of DNS resolutions to [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] organizations, [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] modifies the organization URL used when signing in. When a user signs in, [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] adds “—d” (two dashes + d) to the URL. For example, if the organization URL is **<https://contoso.crm.dynamics.com>**, [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] will change the URL to **<https://contoso--d.crm.dynamics.com>**.  
  
 If a user needs to retry signing in, they’ll see “—d” in the web address. They can sign in with the modified URL or reset it to the URL normally used.  
  
#### After providing credentials the app appears to load indefinitely and never completes  
 This can occur if the time on the device is not within a certain variance of the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] server. For example: you may encounter this issue if the time on the server is 2 PM on November 11th but the device is set to 2 PM on November 12th.  
  
 ![Welcome screen timeout](../../../admin/media/mobile-app-welcometimeout.png "Welcome screen timeout")  
  
 You may see events like the following logged multiple times in the trace files:  
  
 `Dynamics CRM [PAL] | Authentication: Token Expired with Token Timeout value (-255674015) --- Retrieving new Auth Token from shim`  
  
 For possible resolution, see [Microsoft Dynamics CRM for Phone and Tablets cannot connect to Dynamics CRM organization due to length of TokenLifetime](https://support.microsoft.com/kb/3034570)  
  
#### [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] users are repeatedly prompted for sign-in credentials and can’t sign in  
 **Cause**: This can occur if certain directories under the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] website have Windows Authentication enabled. For [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] to successfully connect to a new deployment of [!INCLUDE[pn_crm_2013_server](../../../includes/pn-crm-2013-server.md)] or [!INCLUDE[pn_crm_2015_server](../../../includes/pn-crm-2015-server.md)], you must run a **Repair** of [!INCLUDE[pn_crm_2013_server](../../../includes/pn-crm-2013-server.md)] or [!INCLUDE[pn_crm_2015_server](../../../includes/pn-crm-2015-server.md)], on the server running IIS where the Web Application Server role is installed after the Internet-Facing Deployment Wizard is successfully completed.  
  <!-- 
 For repair instructions, see [Uninstall, change, or repair Microsoft Dynamics 365 apps Server](../Topic/Uninstall,%20change,%20or%20repair%20Microsoft%20Dynamics%20365%20Server.md).  -->
  
> [!IMPORTANT]
>  To resolve this issue by running **Repair**, the [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] deployment must already be configured for claims-based authentication and IFD.
>
> [!NOTE]
>  When the logon prompt appears, it is an [!INCLUDE[pn_Active_Directory](../../../includes/pn-active-directory.md)] logon prompt instead of the sign-in page of your Secure Token Service (STS) such as [!INCLUDE[pn_Active_Dir_Fed_Svcs_AD_FS](../../../includes/pn-active-dir-fed-svcs-ad-fs.md)]. The prompt looks like the one shown here.  
  
 ![Active Directory Sign in](../../../admin/media/mobile-app-adfs-login.png "Active Directory Sign in")  
  
 After you tap **Cancel** or enter credentials 3 times, you see the correct sign-in prompt.  
  
 ![ADFS Sign&#45;in prompt](../../../admin/media/mobile-app-adfs-login-2.png "ADFS Sign-in prompt")  
  
#### Redirected URLs do not work when you configure [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] or [!INCLUDE[pn_Mobile_Express_short](../../../includes/pn-mobile-express-short.md)]  
 URLs that redirect, such as [!INCLUDE[pn_iis](../../../includes/pn-iis.md)] host headers or link-shortening websites such as tinyurl or bitly, do not work when you use the URL in the **Dynamics 365 apps web address** field with [!INCLUDE[pn_moca_full](../../../includes/pn-moca-full.md)] or [!INCLUDE[pn_Mobile_Express_short](../../../includes/pn-mobile-express-short.md)] during configuration.  
  
 For example, an *<https://www.contosocrm.com>* host header for a Dynamics 365 apps online  website URL that is actually *<https://crm.contososerver001.com>*, will not work and will display an error message. To work around this behavior, you must enter the actual web address for the [!INCLUDE[pn_CRM_Online](../../../includes/pn-crm-online.md)] organization. When this issue occurs and you have enabled logging, the information logged is similar to the following. Notice that the URLs in lines 2 and 3 are different. That difference indicates a redirected URL.  
  
1.  User entered URL: *https://URL_entered*  
  
2.  Constructed server URL: *https://URL_after_CRMforTablets_processing*  
  
3.  HTTP Response location: *https://URL_that_the_response_came_from*  
  
 <!-- To enable logging, see [Enable tracing for Dynamics 365 for tablets](../Topic/Monitor%20and%20troubleshoot%20Microsoft%20Dynamics%20365.md#BKMK_MoCA_tracing).  -->

<a name="BKMK_RegardingCustomization"></a>
### Regarding customization

#### Users not getting customizations
 Users will not get customizations made to [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] if there are draft records present. Users should be encouraged to save records as soon as they go online.

#### Data cached for offline viewing remains after the entity is no longer enabled for [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]
 In [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)], record data is cached as the user visits the record so the user can access the data when going offline.

 This cached data persists after the entity is no longer enabled for [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] (**Settings** > **Customizations** > **Customize the System** > [select an entity] > under **Outlook & Mobile**, deselect **[!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]**).

 To remove the cached data, the user must sign out of [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)], or [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] must be reconfigured or uninstalled.

#### Customization changes do not appear in [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)]
 **Cause 1**: The customizations (metadata) from your [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization are cached on your device. The app checks for updated metadata after 24 hours or any time you reopen the app. For customization changes to become available immediately, you must completely close and then reopen the app. If new metadata is found, you will be prompted to download it. For more information on how to completely close an app, refer to the help for your operating system or reference one of the articles provided:

- **Windows 8**: [How do I close an app?](https://go.microsoft.com/fwlink/p/?LinkId=513271)

- **iPad**: [Force an app to close](https://support.apple.com/kb/ht5137)

- **Android**: [How to force close Android apps](https://www.tomsguide.com/faq/id-2372153/force-close-android-apps.html)

**Cause 2**: You may be seeing a different form than the one you customized. If you have multiple forms for an entity, you will see the first form in the form order that you have access to. This is different than the web application where you see the last form you used and have the ability to change between forms.

<a name="BKMK_RegardingMobile"></a>
### Regarding mobile browser

#### Private Browsing not supported in Safari
 If you enable Private Browsing on your iPad in your Safari browser, you will see the following error message when you attempt to connect to your [!INCLUDE[pn_crm_shortest](../../../includes/pn-crm-shortest.md)] organization: “[!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] has encountered an error.” You will need to disable Private Browsing. Tap the address bar, and then tap **Private**.

#### Web app differences in mobile browsers
 For differences you can expect to find in the web app when you’re accessing it from a mobile device, see [Support for Dynamics 365 for phones and Dynamics 365 for tablets](support.md).

<a name="BKMK_Other"></a>
### Other

#### Clipboard data – available to admins and customizers
 [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] System Administrators or System Customizers can access other users’ Clipboard data for users of [!INCLUDE[pn_windows8](../../../includes/pn-windows8.md)] and 8.1 devices.

#### Users can view queue items in another person’s queue
 A user viewing records in [!INCLUDE[pn_moca_short](../../../includes/pn-moca-short.md)] can view records in another user’s queue.

#### Update the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app before updating to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)]
 Users must update to the latest version of the [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] application prior to updating to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)]. On the [Apple App store](https://go.microsoft.com/fwlink/p/?LinkID=524762), the version the users need is 1.1. On the [Good Dynamics Marketplace](https://go.microsoft.com/fwlink/p/?LinkId=524809) or Good Control Console, the version needed is listed as 1.1.0.

 Users who haven’t updated their app prior to connecting to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)], will likely see the following error approximately 2 minutes after connecting to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)].

 Error: We’re sorry. Your server is not available or does not support this application.

 To fix this error, the user must uninstall and reinstall the [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] app using the version listed previously.

#### App restart required after reconfiguring [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)]
 After you reconfigure [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)], the app can get stuck in a loop. You need to close and reopen the app.

1. On your [!INCLUDE[tn_ipad](../../../includes/tn-ipad.md)], press the **Home** button two times quickly. You'll see small previews of your recently used apps.

2. Swipe to find the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app.

3. Swipe up on the app's preview to close it.

4. Tap the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app icon to launch the app and configure for the new org.

### Prevent click for mapping and [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)]
 For users of version 1.0 (1.0.0) of the [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] app that have updated to [!INCLUDE[pn_crm_online_2015_update_1](../../../includes/pn-crm-online-2015-update-1.md)], note that the **Prevent click for mapping** setting does not work.

 To prevent click for mapping in version 1.0 (1.0.0), admins should enable the **Require a secure browser for opening URLs** setting in the [!INCLUDE[pn_good_shortest](../../../includes/pn-good-shortest.md)] Control server, as shown here.

 ![Require a secure browser for opening URLs](../../../admin/media/good-click-mapping.PNG "Require a secure browser for opening URLs")

 The **Prevent click for mapping** setting works as expected in [!INCLUDE[pn_microsoft_dynamics_crm_for_good](../../../includes/pn-microsoft-dynamics-crm-for-good.md)] app version 1.1 (1.1.0). We recommend updating to the latest version of the [!INCLUDE[pn_dynamics_crm_for_good](../../../includes/pn-dynamics-crm-for-good.md)] app rather than applying this workaround.

## Issue still not resolved?
 If the information provided previously doesn’t resolve your issue, either [Post your issue in the Dynamics CRM Community](https://community.dynamics.com/crm/f/117/p/addpost.aspx?GroupToJoin=57) or [Contact Technical Support](/power-platform/admin/get-help-support).

The following are some suggested details to provide:

- What are the specific symptoms you encounter? For example, if you encounter an error, what is the exact error message?

- Does the issue only occur for users with certain [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] security roles?

- Does the issue only occur on certain devices but works correctly for the same user on another device?

- If you attempt to connect to a different [!INCLUDE[pn_microsoftcrm](../../../includes/pn-microsoftcrm.md)] organization that does not include your customizations, does the same issue occur? If the issue only occurs with your customizations, provide a copy of the customizations if possible.

- Does the issue still occur after uninstalling the app and reinstalling it?

<!-- -   Please provide traces. See [Enable tracing for Dynamics 365 for tablets](../Topic/Monitor%20and%20troubleshoot%20Microsoft%20Dynamics%20365.md#BKMK_MoCA_tracing).  -->

-   What type of device (ex. iPad 4th Generation, Microsoft Surface, etc…) are you using and what is the version of the operating system (ex. iOS 6.0, Windows 8, etc…)?



[!INCLUDE[footer-include](../../../includes/footer-banner.md)]