---
title: "Connect to a model-drive app using the Unified Service Desk  client | MicrosoftDocs"
description: "Learn how to connect to the Unified Service Desk solution using the Unified Service Desk client."
author: mh-jaya
ms.author: v-jmh
manager: shujoshi
ms.date: 11/16/2020
ms.topic: article
ms.service: dynamics-365-customerservice
ms.custom: 
  - dyn365-USD
  - dyn365-admin
search.audienceType: 
  - admin
search.app: 
  - D365CE
  - D365USD
tags: MigrationHO
---

# Connect to a model-driven app

[!INCLUDE[cc-data-platform-banner](../../includes/cc-data-platform-banner.md)]

The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is the agent application you can use to connect to the Microsoft Dataverse instance where you've deployed your [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] entities and configuration data. When you sign in by using the client application, it reads the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] configuration on the Dataverse instance, and accordingly exposes the controls and functionality in the application.  

<a name="Signin"></a>
## Sign in to Unified Service Desk

If you want to configure the sign-in experience, such as by pre-populating values in the sign-in dialog box or automatically signing in users without displaying the sign-in dialog box, go to [Configure sign-in information](../../unified-service-desk/admin/connect-dynamics-365-instance-using-unified-service-desk-client.md#ConfigureSignIn).  

1. Start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client by double-clicking the application shortcut on your desktop.  

2. In the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box, provide authentication details to connect to your Dataverse server.

   ![Unified Service Desk client sign-in screen](../../unified-service-desk/media/usd-login.PNG "Unified Service Desk client sign-in screen")  

   - For Dataverse, select **Microsoft 365**.  

   - For Dynamics 365 Customer Engagement (on-premises) deployments, select **On-premises**, and then choose from the following **Authentication Sources**:

     - **Active Directory**. Choose this authentication source if you're connecting to Customer Engagement (on-premises) internally through your network and don't connect to Dataverse through the internet.  

     - **Internet-facing Deployment (IFD)**. Choose this authentication source if you're connecting to Customer Engagement (on-premises) through the internet.  

     - **OAuth**. Choose this authentication source if you're connecting to Customer Engagement (on-premises) by using a security token service (STS)&mdash;other than [!INCLUDE[pn_Windows_Server](../../includes/pn-windows-server.md)]&mdash;that supports the OAuth open framework.  

   - If you have multiple organizations and want to select the organization where [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] is deployed, select the **Display list of available organizations** check box, and then select **Login**.  

3. If you have multiple organizations, select the organization you want to connect to.

4. The [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] splash screen appears. This screen shows information about the configuration data being read by the client in the background. Next, the main window appears and prompts you to enter your Dataverse server credentials. Enter your credentials, and then sign in to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application.  

   Any time you start the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client and need to sign in again, you won't have to provide your connection information again. Your credentials are stored securely in the Windows Credential Manager, and other connection information is stored in the Default_USD.config file at C:\Users\\<USER_NAME\>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\\<Version\> and used for subsequent sign-in activities.  

   If you want to change your connection information to sign in, select **Change Credentials** in the splash screen. You'll see the initial sign-in dialog box where you can enter different credentials.  

   ![Unified Service Desk Change Credentials screen](../../unified-service-desk/media/usd-second-signin.png "Unified Service Desk Change Credentials screen")

::: moniker range=">=dynamics-usd-4.1"

## Single sign-on for Unified Service Desk

Single sign-on (SSO) for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides an improved startup performance and user experience by authenticating users to access model-driven apps without the need for entering their credentials multiple times. This eliminates the need for entering the same password again, thereby minimizing the likelihood of sign-in errors, and helps ensure a seamless user experience.

### Understand SSO for Unified Service Desk

While signing in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] you must enter the model-driven app credentials and sign in, and then again you're shown a dialog box to enter credentials to connect to Dataverse. The SSO feature was introduced to avoid this.

By default, the SSO feature is disabled for the Chrome Process. To enable the SSO feature, follow the steps in [Change the SingleSignOnThreshold value](#change-the-singlesignonthreshold-value). With SSO, you need to enter the credentials only once while signing in to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application and the Dataverse server.

> [!NOTE]
> - The SSO feature is available only for model-driven apps and Unified Service Desk.
>
> - If your organization has enforced the inactivity session timeout for agents, with the Chrome Process the agent won't be automatically signed out when the inactivity session timeout expires because SSO is enabled by default. If you want to enforce an inactivity session timeout for agents, disable the SSO feature for the Chrome Process. More information: [Disable single sign-on](#enable-or-disable-single-sign-on)
>
> - SSO isn't supported for Dynamics 365 Customer Engagement (on-premises).

**SingleSignOnThreshold** is a UII option that indicates the timeout period in milliseconds (ms) for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] to wait before showing a dialog box to enter credentials to sign in to the Dataverse server. By default, the **SingleSignOnThreshold** value is 5,000 ms. To learn more, see [Manage options in Unified Service Desk](../admin/manage-options-unified-service-desk.md). The **SingleSignOnThreshold** UII option works only when you configure the **SingleSignOnEnabledBrowsers** UII option and specify a valid value.

To change the timeout value, configure the **SingleSignOnThreshold** UII option and enter a value in the range from 1,000 through 60,000 ms. If you enter a value less than 1,000 ms or more than 60,000 ms, [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] resets the value to the default of 5,000 ms.

|Value in ms | Description |
|-------|------------------------|
| 5,000 | Default value |
| 1,000&ndash;60,000 | Accepted value range |
| > 60,000 | Value is reset to 5,000 ms |

### Change the SingleSignOnThreshold value

1. Sign in to the Unified Service Desk Administrator app.

2. Select **Options**.  

3. On the **Active UII Options** page, select **+ New**.

4. For **Name**, enter **SingleSignOnThreshold**. For **Value**, enter the time in ms.

5. Select **Save**.

After you set up the abovementioned UII options, the SSO feature is enabled. While signing in to the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client application, you only need to enter credentials once.

<a name="enable-or-disable-single-sign-on"></a>
### Enable or disable SSO

To enable the SSO feature, you must the configure the **SingleSignOnEnabledBrowsers** UII option and set it to **True**. If you leave the value bank, SSO will still be enabled. To disable the SSO feature, set the value as **False**.

**To enable or disable SSO**

1. Sign in to the Unified Service Desk Administrator app.

2. Select **Options**.  

3. On the **Active UII Options** page, select **+ New**.

4. For **Name**, enter **SingleSignOnEnabledBrowsers**. For **Value**, enter **Chrome**.

5. Select **Save**.

::: moniker-end

<a name="ConfigureSignIn"></a>   
## Configure sign-in information

If needed, administrators can configure the sign-in experience for [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] by pre-populating values (except username and password) in the sign-in dialog box so users can connect to the specified Dataverse instance, or they can configure it to automatically sign in users to an on-premises Dataverse instance based on the user's [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] credentials without even displaying the sign-in dialog box.

> [!NOTE]
>  You can't add or remove the fields in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box. You can only specify the values that will appear in the fields when a user tries to sign in. However, users can change the pre-populated values in the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in dialog box before signing in.

To configure sign-in information, use the UnifiedServiceDesk.exe.config file that's available in the client installation directory (typically C:\Program Files\Microsoft Dynamics CRM USD\USD).  

1. Run [!INCLUDE[pn_Notepad](../../includes/pn-notepad.md)] as an administrator.  

2. In [!INCLUDE[pn_Notepad](../../includes/pn-notepad.md)], open the UnifiedServiceDesk.exe.config file from the client installation directory (typically C:\Program Files\Microsoft Dynamics CRM USD\USD).  

3. Add the following keys under the `<appSettings>` node in the UnifiedServiceDesk.exe.config file.  

   ```xml  
   <add key="CrmDeploymentType" value="<DEPLOYMENT_TYPE>" />  
   <add key="CrmUseSSL" value="<VALUE>" />  
   <add key="CrmOrg" value="<ORG_NAME>" />  
   <add key="CrmPort" value="<PORT_NUMBER>" />  
   <add key="CrmServerName" value="<CRM_SERVER_NAME>" />  
   <add key="UseDefaultCreds" value="<VALUE>" />  
   <add key="CacheCredentials" value="<VALUE>" />  
   <add key="CrmOnlineRegion" value="<CRM_ONLINE_REGION>" />  
   <add key="AuthHomeRealm" value="<VALUE>" />  
   <add key="AskForOrg" value="<VALUE>" />  
   <add key="CrmDomain" value="<DOMAIN_NAME>" />  
   ```  

4. Provide an appropriate value for each key. Each key maps to an individual field in the sign-in dialog box. The following table shows valid key values.  


   |         Key         |                                                                                                                                                                                                                                             Value                                                                                                                                                                                                                                             |
   |---------------------|-----------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------------|
   | `CrmDeploymentType` |                                                      `Prem` or `O365`<br /><br /> `Prem` must be used if you're connecting to Customer Engagement (on-premises); `O365` must be used if you're connecting to Dataverse.                                                       |
   |     `CrmUseSSL`     |                                                                                                                                                                                       `True` or `False`<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.                                                                                                                                                                                       |
   |      `CrmOrg`       |                                                                                                                                                                                                 Specify the Dataverse organization name.                                                                                                                                                                                                  |
   |      `CrmPort`      |                                                                                                                                                    Specify the Dataverse port number.<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.                                                                                                                                                     |
   |   `CrmServerName`   |                                                                                                                                                    Specify the Dataverse server name.<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.                                                                                                                                                     |
   |  `UseDefaultCreds`  | `True` or `False`<br><br>**Note:**  For Customer Engagement (on-premises) installation `(<add key="CrmDeploymentType" value="Prem" />`) and Active Directory authentication `(<add key="AuthHomeRealm" value="Active Directory" />`), set the value of this key to `True` to directly sign in users to the specified Dataverse server or organization without even displaying the sign-in dialog box.  |
   | `CacheCredentials`  | `True` or `False`<br><br> **Note:**  To force the connection dialog box to be displayed every time the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] client is opened, set the value of this key to `False`. By default, the client caches the last connection information and uses it the next time to establish a connection to the Dataverse server (unless the user cancels and specifies a different connection). |
   |  `CrmOnlineRegion`  |                                                                                                     `NorthAmerica`, `EMEA`, `APAC`, `SouthAmerica`, `Oceania`, `JPN`, `CAN`, `IND`, or `NorthAmerica2`<br /><br /> If you don't know the online region, leave the value empty: `value=""`<br /><br /> This key is applicable only if you specified `O365` in the `CrmDeploymentType` key.                                                                                                     |
   |   `AuthHomeRealm`   |                                                                                                                                                                   `Active Directory` or `Internet-facing deployment(IFD)`<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.                                                                                                                                                                    |
   |     `AskForOrg`     |                                                                                                                                                                       `True` or `False`<br /><br /> Indicates whether the **Display list of available organizations** check box is selected in the sign-in dialog box.                                                                                                                                                                        |
   |     `CrmDomain`     |                                                                                                                                                  Specify the name of the [!INCLUDE[pn_ms_Windows_short](../../includes/pn-ms-windows-short.md)] domain.<br /><br /> This key is applicable only if you specified `Prem` in the `CrmDeploymentType` key.                                                                                                                                                   |

5. Save the UnifiedServiceDesk.exe.config file.  

6. Do the following on *each* user's computer where you want to configure sign-in information:  

   1. Copy the UnifiedServiceDesk.exe.config file that you just modified to the client installation directory (typically C:\Program Files\Microsoft Dynamics CRM USD\USD) to replace the existing file.  

   2. Remove the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] sign-in information from the roaming user profiles on the user's computer. If the user has signed in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] from the computer at least once, the following files were created in the C:\Users\\<USER_NAME\>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk directory: Default_USD.config and Default_USD. You must delete both these files for the configuration settings in the UnifiedServiceDesk.exe.config file to take effect.  

   When the user starts the [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] application on their computer:  

   - The sign-in dialog box shows the values specified in the UnifiedServiceDesk.exe.config file and also creates the Default_USD.config file in the C:\Users\\<USER_NAME\>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk directory to store the connection information (except username and password; these are stored in [!INCLUDE[pn_Windows_Credential_Manager](../../includes/pn-windows-credential-manager.md)]). Thereafter, the client application uses the Default_USD.config file to display the sign-in information or to automatically sign in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].  

   - For a Customer Engagement (on-premises) installation with [!INCLUDE[pn_Active_Directory](../../includes/pn-active-directory.md)] authentication, if you've configured to automatically sign in the user without displaying the sign-in dialog box (`<add key="UseDefaultCreds" value="True" />`), the sign-in dialog box isn't displayed, but the Default_USD.config file is created in the C:\Users\\<USER_NAME\>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk directory to store the connection information (except username and password). Thereafter, the client application uses the Default_USD.config file to automatically sign in to [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)].

If you need to modify the default sign-in information, you must repeat steps 1 through 6.  

<a name="LogFiles"></a>   
## Troubleshoot sign-in issues

[!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] provides logging support to log errors that can occur while signing in to Dataverse. A log file, Login_ErrorLog.log, is created at C:\Users\\<USER_NAME\>\AppData\Roaming\Microsoft\Microsoft Dynamics 365 Unified Service Desk\\<Version\> the first time you encounter any sign-in issues in the client application. Thereafter, the log file is used to record information about subsequent sign-in issues. This information can be helpful for troubleshooting issues related to signing in to Dataverse from the client application.  

> [!NOTE]
> [!INCLUDE[pn_unified_service_desk](../../includes/pn-unified-service-desk.md)] also creates another log file, UnifiedServiceDesk.log, at the same location to log operational errors in the client application. The log file is created the first time you encounter any issues in the client application. [!INCLUDE[proc_more_information](../../includes/proc-more-information.md)] [Configure diagnostic logging in Unified Service Desk](../../unified-service-desk/admin/configure-client-diagnostic-logging-unified-service-desk.md)  

### See also

 [Manage access in Unified Service Desk](../../unified-service-desk/admin/security-unified-service-desk.md)   
 [Learn to use Unified Service Desk](../../unified-service-desk/learn-to-use-unified-service-desk.md)   
 [Unified Service Desk configuration walkthroughs](../../unified-service-desk/unified-service-desk-configuration-walkthroughs.md)   
 [Administer and manage overview](../../unified-service-desk/admin/administer-manage-unified-service-desk.md)


[!INCLUDE[footer-include](../../includes/footer-banner.md)]